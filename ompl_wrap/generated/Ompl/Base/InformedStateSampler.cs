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

public class InformedStateSampler : StateSampler {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal InformedStateSampler(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ompl_basePINVOKE.InformedStateSampler_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(InformedStateSampler obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          ompl_basePINVOKE.delete_InformedStateSampler(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public InformedStateSampler(ProblemDefinition probDefn, uint maxNumberCalls, SWIGTYPE_p_std__functionT_ompl__base__Cost_fF_t costFunc) : this(ompl_basePINVOKE.new_InformedStateSampler__SWIG_0(ProblemDefinition.getCPtr(probDefn), maxNumberCalls, SWIGTYPE_p_std__functionT_ompl__base__Cost_fF_t.getCPtr(costFunc)), true) {
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public InformedStateSampler(ProblemDefinition probDefn, SWIGTYPE_p_std__functionT_ompl__base__Cost_fF_t costFunc, SWIGTYPE_p_std__shared_ptrT_ompl__base__InformedSampler_t infSampler) : this(ompl_basePINVOKE.new_InformedStateSampler__SWIG_1(ProblemDefinition.getCPtr(probDefn), SWIGTYPE_p_std__functionT_ompl__base__Cost_fF_t.getCPtr(costFunc), SWIGTYPE_p_std__shared_ptrT_ompl__base__InformedSampler_t.getCPtr(infSampler)), true) {
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void sampleUniform(State statePtr) {
    ompl_basePINVOKE.InformedStateSampler_sampleUniform(swigCPtr, State.getCPtr(statePtr));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void sampleUniformNear(State statePtr, State near, double distance) {
    ompl_basePINVOKE.InformedStateSampler_sampleUniformNear(swigCPtr, State.getCPtr(statePtr), State.getCPtr(near), distance);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void sampleGaussian(State statePtr, State mean, double stdDev) {
    ompl_basePINVOKE.InformedStateSampler_sampleGaussian(swigCPtr, State.getCPtr(statePtr), State.getCPtr(mean), stdDev);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

}

}