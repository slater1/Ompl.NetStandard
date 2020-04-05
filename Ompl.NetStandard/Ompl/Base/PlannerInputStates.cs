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

public class PlannerInputStates : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PlannerInputStates(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PlannerInputStates obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PlannerInputStates() {
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
          ompl_basePINVOKE.delete_PlannerInputStates(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public PlannerInputStates(Planner planner) : this(ompl_basePINVOKE.new_PlannerInputStates__SWIG_0(Planner.getCPtr(planner)), true) {
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public PlannerInputStates() : this(ompl_basePINVOKE.new_PlannerInputStates__SWIG_2(), true) {
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void clear() {
    ompl_basePINVOKE.PlannerInputStates_clear(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void restart() {
    ompl_basePINVOKE.PlannerInputStates_restart(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool update() {
    bool ret = ompl_basePINVOKE.PlannerInputStates_update(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool use(ProblemDefinition pdef) {
    bool ret = ompl_basePINVOKE.PlannerInputStates_use__SWIG_0(swigCPtr, ProblemDefinition.getCPtr(pdef));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void checkValidity() {
    ompl_basePINVOKE.PlannerInputStates_checkValidity(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public State nextStart() {
    global::System.IntPtr cPtr = ompl_basePINVOKE.PlannerInputStates_nextStart(swigCPtr);
    State ret = (cPtr == global::System.IntPtr.Zero) ? null : new State(cPtr, false);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public State nextGoal(PlannerTerminationCondition ptc) {
    global::System.IntPtr cPtr = ompl_basePINVOKE.PlannerInputStates_nextGoal__SWIG_0(swigCPtr, PlannerTerminationCondition.getCPtr(ptc));
    State ret = (cPtr == global::System.IntPtr.Zero) ? null : new State(cPtr, false);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public State nextGoal() {
    global::System.IntPtr cPtr = ompl_basePINVOKE.PlannerInputStates_nextGoal__SWIG_1(swigCPtr);
    State ret = (cPtr == global::System.IntPtr.Zero) ? null : new State(cPtr, false);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool haveMoreStartStates() {
    bool ret = ompl_basePINVOKE.PlannerInputStates_haveMoreStartStates(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool haveMoreGoalStates() {
    bool ret = ompl_basePINVOKE.PlannerInputStates_haveMoreGoalStates(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getSeenStartStatesCount() {
    uint ret = ompl_basePINVOKE.PlannerInputStates_getSeenStartStatesCount(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getSampledGoalsCount() {
    uint ret = ompl_basePINVOKE.PlannerInputStates_getSampledGoalsCount(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
