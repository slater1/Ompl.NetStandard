//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class SpaceInformation : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SpaceInformation(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SpaceInformation obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SpaceInformation() {
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
          ompl_wrapPINVOKE.delete_SpaceInformation(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public SpaceInformation(SWIGTYPE_p_std__shared_ptrT_ompl__base__StateSpace_t stateSpace, SWIGTYPE_p_std__shared_ptrT_ompl__control__ControlSpace_t controlSpace) : this(ompl_wrapPINVOKE.new_SpaceInformation(SWIGTYPE_p_std__shared_ptrT_ompl__base__StateSpace_t.getCPtr(stateSpace), SWIGTYPE_p_std__shared_ptrT_ompl__control__ControlSpace_t.getCPtr(controlSpace)), true) {
    if (ompl_wrapPINVOKE.SWIGPendingException.Pending) throw ompl_wrapPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_std__shared_ptrT_ompl__control__ControlSpace_t getControlSpace() {
    SWIGTYPE_p_std__shared_ptrT_ompl__control__ControlSpace_t ret = new SWIGTYPE_p_std__shared_ptrT_ompl__control__ControlSpace_t(ompl_wrapPINVOKE.SpaceInformation_getControlSpace(swigCPtr), false);
    return ret;
  }

  public Control allocControl() {
    global::System.IntPtr cPtr = ompl_wrapPINVOKE.SpaceInformation_allocControl(swigCPtr);
    Control ret = (cPtr == global::System.IntPtr.Zero) ? null : new Control(cPtr, false);
    return ret;
  }

  public void freeControl(Control control) {
    ompl_wrapPINVOKE.SpaceInformation_freeControl(swigCPtr, Control.getCPtr(control));
  }

  public void copyControl(Control destination, Control source) {
    ompl_wrapPINVOKE.SpaceInformation_copyControl(swigCPtr, Control.getCPtr(destination), Control.getCPtr(source));
  }

  public Control cloneControl(Control source) {
    global::System.IntPtr cPtr = ompl_wrapPINVOKE.SpaceInformation_cloneControl(swigCPtr, Control.getCPtr(source));
    Control ret = (cPtr == global::System.IntPtr.Zero) ? null : new Control(cPtr, false);
    return ret;
  }

  public void printControl(Control control, SWIGTYPE_p_std__ostream out_) {
    ompl_wrapPINVOKE.SpaceInformation_printControl__SWIG_0(swigCPtr, Control.getCPtr(control), SWIGTYPE_p_std__ostream.getCPtr(out_));
    if (ompl_wrapPINVOKE.SWIGPendingException.Pending) throw ompl_wrapPINVOKE.SWIGPendingException.Retrieve();
  }

  public void printControl(Control control) {
    ompl_wrapPINVOKE.SpaceInformation_printControl__SWIG_1(swigCPtr, Control.getCPtr(control));
  }

  public bool equalControls(Control control1, Control control2) {
    bool ret = ompl_wrapPINVOKE.SpaceInformation_equalControls(swigCPtr, Control.getCPtr(control1), Control.getCPtr(control2));
    return ret;
  }

  public void nullControl(Control control) {
    ompl_wrapPINVOKE.SpaceInformation_nullControl(swigCPtr, Control.getCPtr(control));
  }

  public SWIGTYPE_p_std__shared_ptrT_ompl__control__ControlSampler_t allocControlSampler() {
    SWIGTYPE_p_std__shared_ptrT_ompl__control__ControlSampler_t ret = new SWIGTYPE_p_std__shared_ptrT_ompl__control__ControlSampler_t(ompl_wrapPINVOKE.SpaceInformation_allocControlSampler(swigCPtr), true);
    return ret;
  }

  public void setMinMaxControlDuration(uint minSteps, uint maxSteps) {
    ompl_wrapPINVOKE.SpaceInformation_setMinMaxControlDuration(swigCPtr, minSteps, maxSteps);
  }

  public void setMinControlDuration(uint minSteps) {
    ompl_wrapPINVOKE.SpaceInformation_setMinControlDuration(swigCPtr, minSteps);
  }

  public void setMaxControlDuration(uint maxSteps) {
    ompl_wrapPINVOKE.SpaceInformation_setMaxControlDuration(swigCPtr, maxSteps);
  }

  public uint getMinControlDuration() {
    uint ret = ompl_wrapPINVOKE.SpaceInformation_getMinControlDuration(swigCPtr);
    return ret;
  }

  public uint getMaxControlDuration() {
    uint ret = ompl_wrapPINVOKE.SpaceInformation_getMaxControlDuration(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_std__shared_ptrT_ompl__control__DirectedControlSampler_t allocDirectedControlSampler() {
    SWIGTYPE_p_std__shared_ptrT_ompl__control__DirectedControlSampler_t ret = new SWIGTYPE_p_std__shared_ptrT_ompl__control__DirectedControlSampler_t(ompl_wrapPINVOKE.SpaceInformation_allocDirectedControlSampler(swigCPtr), true);
    return ret;
  }

  public void setDirectedControlSamplerAllocator(SWIGTYPE_p_std__functionT_std__shared_ptrT_ompl__control__DirectedControlSampler_t_fompl__control__SpaceInformation_const_pF_t dcsa) {
    ompl_wrapPINVOKE.SpaceInformation_setDirectedControlSamplerAllocator(swigCPtr, SWIGTYPE_p_std__functionT_std__shared_ptrT_ompl__control__DirectedControlSampler_t_fompl__control__SpaceInformation_const_pF_t.getCPtr(dcsa));
    if (ompl_wrapPINVOKE.SWIGPendingException.Pending) throw ompl_wrapPINVOKE.SWIGPendingException.Retrieve();
  }

  public void clearDirectedSamplerAllocator() {
    ompl_wrapPINVOKE.SpaceInformation_clearDirectedSamplerAllocator(swigCPtr);
  }

  public SWIGTYPE_p_std__shared_ptrT_ompl__control__StatePropagator_t getStatePropagator() {
    SWIGTYPE_p_std__shared_ptrT_ompl__control__StatePropagator_t ret = new SWIGTYPE_p_std__shared_ptrT_ompl__control__StatePropagator_t(ompl_wrapPINVOKE.SpaceInformation_getStatePropagator(swigCPtr), false);
    return ret;
  }

  public void setStatePropagator(SWIGTYPE_p_std__functionT_void_fompl__base__State_const_p_ompl__control__Control_const_p_double_const_ompl__base__State_pF_t fn) {
    ompl_wrapPINVOKE.SpaceInformation_setStatePropagator__SWIG_0(swigCPtr, SWIGTYPE_p_std__functionT_void_fompl__base__State_const_p_ompl__control__Control_const_p_double_const_ompl__base__State_pF_t.getCPtr(fn));
    if (ompl_wrapPINVOKE.SWIGPendingException.Pending) throw ompl_wrapPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setStatePropagator(SWIGTYPE_p_std__shared_ptrT_ompl__control__StatePropagator_t sp) {
    ompl_wrapPINVOKE.SpaceInformation_setStatePropagator__SWIG_1(swigCPtr, SWIGTYPE_p_std__shared_ptrT_ompl__control__StatePropagator_t.getCPtr(sp));
    if (ompl_wrapPINVOKE.SWIGPendingException.Pending) throw ompl_wrapPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setPropagationStepSize(double stepSize) {
    ompl_wrapPINVOKE.SpaceInformation_setPropagationStepSize(swigCPtr, stepSize);
  }

  public double getPropagationStepSize() {
    double ret = ompl_wrapPINVOKE.SpaceInformation_getPropagationStepSize(swigCPtr);
    return ret;
  }

  public void propagate(State state, Control control, int steps, State result) {
    ompl_wrapPINVOKE.SpaceInformation_propagate__SWIG_0(swigCPtr, State.getCPtr(state), Control.getCPtr(control), steps, State.getCPtr(result));
  }

  public bool canPropagateBackward() {
    bool ret = ompl_wrapPINVOKE.SpaceInformation_canPropagateBackward(swigCPtr);
    return ret;
  }

  public uint propagateWhileValid(State state, Control control, int steps, State result) {
    uint ret = ompl_wrapPINVOKE.SpaceInformation_propagateWhileValid__SWIG_0(swigCPtr, State.getCPtr(state), Control.getCPtr(control), steps, State.getCPtr(result));
    return ret;
  }

  public void propagate(State state, Control control, int steps, SWIGTYPE_p_std__vectorT_ompl__base__State_p_t result, bool alloc) {
    ompl_wrapPINVOKE.SpaceInformation_propagate__SWIG_1(swigCPtr, State.getCPtr(state), Control.getCPtr(control), steps, SWIGTYPE_p_std__vectorT_ompl__base__State_p_t.getCPtr(result), alloc);
    if (ompl_wrapPINVOKE.SWIGPendingException.Pending) throw ompl_wrapPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint propagateWhileValid(State state, Control control, int steps, SWIGTYPE_p_std__vectorT_ompl__base__State_p_t result, bool alloc) {
    uint ret = ompl_wrapPINVOKE.SpaceInformation_propagateWhileValid__SWIG_1(swigCPtr, State.getCPtr(state), Control.getCPtr(control), steps, SWIGTYPE_p_std__vectorT_ompl__base__State_p_t.getCPtr(result), alloc);
    if (ompl_wrapPINVOKE.SWIGPendingException.Pending) throw ompl_wrapPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void printSettings(SWIGTYPE_p_std__ostream out_) {
    ompl_wrapPINVOKE.SpaceInformation_printSettings__SWIG_0(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(out_));
    if (ompl_wrapPINVOKE.SWIGPendingException.Pending) throw ompl_wrapPINVOKE.SWIGPendingException.Retrieve();
  }

  public void printSettings() {
    ompl_wrapPINVOKE.SpaceInformation_printSettings__SWIG_1(swigCPtr);
  }

  public void setup() {
    ompl_wrapPINVOKE.SpaceInformation_setup(swigCPtr);
  }

}
