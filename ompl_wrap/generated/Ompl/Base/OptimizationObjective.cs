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

public class OptimizationObjective : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal OptimizationObjective(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(OptimizationObjective obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~OptimizationObjective() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnBase) {
          swigCMemOwnBase = false;
          ompl_basePINVOKE.delete_OptimizationObjective(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string getDescription() {
    string ret = ompl_basePINVOKE.OptimizationObjective_getDescription(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool isSatisfied(Cost c) {
    bool ret = ompl_basePINVOKE.OptimizationObjective_isSatisfied(swigCPtr, Cost.getCPtr(c));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Cost getCostThreshold() {
    Cost ret = new Cost(ompl_basePINVOKE.OptimizationObjective_getCostThreshold(swigCPtr), true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setCostThreshold(Cost c) {
    ompl_basePINVOKE.OptimizationObjective_setCostThreshold(swigCPtr, Cost.getCPtr(c));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool isCostBetterThan(Cost c1, Cost c2) {
    bool ret = ompl_basePINVOKE.OptimizationObjective_isCostBetterThan(swigCPtr, Cost.getCPtr(c1), Cost.getCPtr(c2));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool isCostEquivalentTo(Cost c1, Cost c2) {
    bool ret = ompl_basePINVOKE.OptimizationObjective_isCostEquivalentTo(swigCPtr, Cost.getCPtr(c1), Cost.getCPtr(c2));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool isFinite(Cost cost) {
    bool ret = ompl_basePINVOKE.OptimizationObjective_isFinite(swigCPtr, Cost.getCPtr(cost));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Cost betterCost(Cost c1, Cost c2) {
    Cost ret = new Cost(ompl_basePINVOKE.OptimizationObjective_betterCost(swigCPtr, Cost.getCPtr(c1), Cost.getCPtr(c2)), true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Cost stateCost(State s) {
    Cost ret = new Cost(ompl_basePINVOKE.OptimizationObjective_stateCost(swigCPtr, State.getCPtr(s)), true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Cost motionCost(State s1, State s2) {
    Cost ret = new Cost(ompl_basePINVOKE.OptimizationObjective_motionCost(swigCPtr, State.getCPtr(s1), State.getCPtr(s2)), true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Cost combineCosts(Cost c1, Cost c2) {
    Cost ret = new Cost(ompl_basePINVOKE.OptimizationObjective_combineCosts(swigCPtr, Cost.getCPtr(c1), Cost.getCPtr(c2)), true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Cost identityCost() {
    Cost ret = new Cost(ompl_basePINVOKE.OptimizationObjective_identityCost(swigCPtr), true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Cost infiniteCost() {
    Cost ret = new Cost(ompl_basePINVOKE.OptimizationObjective_infiniteCost(swigCPtr), true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Cost initialCost(State s) {
    Cost ret = new Cost(ompl_basePINVOKE.OptimizationObjective_initialCost(swigCPtr, State.getCPtr(s)), true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Cost terminalCost(State s) {
    Cost ret = new Cost(ompl_basePINVOKE.OptimizationObjective_terminalCost(swigCPtr, State.getCPtr(s)), true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool isSymmetric() {
    bool ret = ompl_basePINVOKE.OptimizationObjective_isSymmetric(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Cost averageStateCost(uint numStates) {
    Cost ret = new Cost(ompl_basePINVOKE.OptimizationObjective_averageStateCost(swigCPtr, numStates), true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setCostToGoHeuristic(SWIGTYPE_p_std__functionT_ompl__base__Cost_fompl__base__State_const_p_ompl__base__Goal_const_pF_t costToGo) {
    ompl_basePINVOKE.OptimizationObjective_setCostToGoHeuristic(swigCPtr, SWIGTYPE_p_std__functionT_ompl__base__Cost_fompl__base__State_const_p_ompl__base__Goal_const_pF_t.getCPtr(costToGo));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool hasCostToGoHeuristic() {
    bool ret = ompl_basePINVOKE.OptimizationObjective_hasCostToGoHeuristic(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Cost costToGo(State state, Goal goal) {
    Cost ret = new Cost(ompl_basePINVOKE.OptimizationObjective_costToGo(swigCPtr, State.getCPtr(state), Goal.getCPtr(goal)), true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Cost motionCostHeuristic(State s1, State s2) {
    Cost ret = new Cost(ompl_basePINVOKE.OptimizationObjective_motionCostHeuristic(swigCPtr, State.getCPtr(s1), State.getCPtr(s2)), true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SpaceInformation getSpaceInformation() {
    global::System.IntPtr cPtr = ompl_basePINVOKE.OptimizationObjective_getSpaceInformation(swigCPtr);
    SpaceInformation ret = (cPtr == global::System.IntPtr.Zero) ? null : new SpaceInformation(cPtr, true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_std__shared_ptrT_ompl__base__InformedSampler_t allocInformedStateSampler(ProblemDefinition probDefn, uint maxNumberCalls) {
    SWIGTYPE_p_std__shared_ptrT_ompl__base__InformedSampler_t ret = new SWIGTYPE_p_std__shared_ptrT_ompl__base__InformedSampler_t(ompl_basePINVOKE.OptimizationObjective_allocInformedStateSampler(swigCPtr, ProblemDefinition.getCPtr(probDefn), maxNumberCalls), true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void _print(SWIGTYPE_p_std__ostream _out) {
    ompl_basePINVOKE.OptimizationObjective__print(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(_out));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

}

}