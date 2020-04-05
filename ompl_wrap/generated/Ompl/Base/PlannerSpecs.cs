//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Ompl.Base {

public class PlannerSpecs : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PlannerSpecs(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PlannerSpecs obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PlannerSpecs() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ompl_basePINVOKE.delete_PlannerSpecs(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public PlannerSpecs() : this(ompl_basePINVOKE.new_PlannerSpecs(), true) {
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public GoalType recognizedGoal {
    set {
      ompl_basePINVOKE.PlannerSpecs_recognizedGoal_set(swigCPtr, (int)value);
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      GoalType ret = (GoalType)ompl_basePINVOKE.PlannerSpecs_recognizedGoal_get(swigCPtr);
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool multithreaded {
    set {
      ompl_basePINVOKE.PlannerSpecs_multithreaded_set(swigCPtr, value);
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = ompl_basePINVOKE.PlannerSpecs_multithreaded_get(swigCPtr);
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool approximateSolutions {
    set {
      ompl_basePINVOKE.PlannerSpecs_approximateSolutions_set(swigCPtr, value);
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = ompl_basePINVOKE.PlannerSpecs_approximateSolutions_get(swigCPtr);
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool optimizingPaths {
    set {
      ompl_basePINVOKE.PlannerSpecs_optimizingPaths_set(swigCPtr, value);
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = ompl_basePINVOKE.PlannerSpecs_optimizingPaths_get(swigCPtr);
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool directed {
    set {
      ompl_basePINVOKE.PlannerSpecs_directed_set(swigCPtr, value);
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = ompl_basePINVOKE.PlannerSpecs_directed_get(swigCPtr);
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool provingSolutionNonExistence {
    set {
      ompl_basePINVOKE.PlannerSpecs_provingSolutionNonExistence_set(swigCPtr, value);
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = ompl_basePINVOKE.PlannerSpecs_provingSolutionNonExistence_get(swigCPtr);
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool canReportIntermediateSolutions {
    set {
      ompl_basePINVOKE.PlannerSpecs_canReportIntermediateSolutions_set(swigCPtr, value);
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = ompl_basePINVOKE.PlannerSpecs_canReportIntermediateSolutions_get(swigCPtr);
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}

}
