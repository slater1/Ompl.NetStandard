//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ControlSampler : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ControlSampler(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ControlSampler obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ControlSampler() {
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
          ompl_wrapPINVOKE.delete_ControlSampler(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public virtual void sample(Control control) {
    ompl_wrapPINVOKE.ControlSampler_sample__SWIG_0(swigCPtr, Control.getCPtr(control));
  }

  public virtual void sample(Control control, State state) {
    ompl_wrapPINVOKE.ControlSampler_sample__SWIG_1(swigCPtr, Control.getCPtr(control), State.getCPtr(state));
  }

  public virtual void sampleNext(Control control, Control previous) {
    ompl_wrapPINVOKE.ControlSampler_sampleNext__SWIG_0(swigCPtr, Control.getCPtr(control), Control.getCPtr(previous));
  }

  public virtual void sampleNext(Control control, Control previous, State state) {
    ompl_wrapPINVOKE.ControlSampler_sampleNext__SWIG_1(swigCPtr, Control.getCPtr(control), Control.getCPtr(previous), State.getCPtr(state));
  }

  public virtual uint sampleStepCount(uint minSteps, uint maxSteps) {
    uint ret = ompl_wrapPINVOKE.ControlSampler_sampleStepCount(swigCPtr, minSteps, maxSteps);
    return ret;
  }

}
