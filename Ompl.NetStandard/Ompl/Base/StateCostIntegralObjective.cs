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

public class StateCostIntegralObjective : OptimizationObjective {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal StateCostIntegralObjective(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ompl_basePINVOKE.StateCostIntegralObjective_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(StateCostIntegralObjective obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ompl_basePINVOKE.delete_StateCostIntegralObjective(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public StateCostIntegralObjective(SpaceInformation si, bool enableMotionCostInterpolation) : this(ompl_basePINVOKE.new_StateCostIntegralObjective__SWIG_0(SpaceInformation.getCPtr(si), enableMotionCostInterpolation), true) {
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public StateCostIntegralObjective(SpaceInformation si) : this(ompl_basePINVOKE.new_StateCostIntegralObjective__SWIG_1(SpaceInformation.getCPtr(si)), true) {
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public override Cost stateCost(State s) {
    Cost ret = new Cost(ompl_basePINVOKE.StateCostIntegralObjective_stateCost(swigCPtr, State.getCPtr(s)), true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override Cost motionCost(State s1, State s2) {
    Cost ret = new Cost(ompl_basePINVOKE.StateCostIntegralObjective_motionCost(swigCPtr, State.getCPtr(s1), State.getCPtr(s2)), true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isMotionCostInterpolationEnabled() {
    bool ret = ompl_basePINVOKE.StateCostIntegralObjective_isMotionCostInterpolationEnabled(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
