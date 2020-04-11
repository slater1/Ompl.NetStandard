%{

#include "ompl/util/Time.h"
#include "ompl/util/ProlateHyperspheroid.h"
#include "ompl/util/RandomNumbers.h"

#include "ompl/datastructures/BinaryHeap.h"
#include "ompl/datastructures/Grid.h"
#include "ompl/datastructures/GridN.h"
#include "ompl/datastructures/GridB.h"

// Disable null dereference warnings
#pragma warning(push)
#pragma warning(disable : 6011)

%}

// Ignore Eigen
%ignore ompl::base::ProjectionMatrix;
%ignore ompl::base::ProjectionEvaluator;

// Prevent Error CS0506 'CompoundStateSpace.allocSubspaceStateSampler(StateSpace)': 
// cannot override inherited member 'StateSpace.allocSubspaceStateSampler(StateSpace)' 
// because it is not marked virtual, abstract, or override
%ignore ompl::base::CompoundStateSpace::allocSubspaceStateSampler;

// Handle namespace conflicts
%rename("Base") ompl::base;

%include "carrays.i"
%array_functions(double, doubleArray);
%array_functions(int, intArray);

%include "std_string.i"
%include "std_vector.i"
%include "std_shared_ptr.i"

%template(doubleVector) std::vector<double>;
%template(intVector) std::vector<int>;

// Pass std::exception up to C#
%include "exception.i"
%allowexception;
%exception {
  try {
    $action
  } catch (const std::exception& e) {
    SWIG_exception(SWIG_RuntimeError, e.what());
  }
}

%include "ompl/util/ClassForward.h"
%include "ompl/util/Time.h"
%include "ompl/util/ProlateHyperspheroid.h"
%include "ompl/util/RandomNumbers.h"

%include "ompl/datastructures/BinaryHeap.h"
// Ignore this macro
%define EIGEN_MAKE_ALIGNED_OPERATOR_NEW(x) 0
%include "ompl/datastructures/Grid.h"
%include "ompl/datastructures/GridN.h"
%include "ompl/datastructures/GridB.h"
%enddef