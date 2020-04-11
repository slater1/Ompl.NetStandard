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

public class StateSpace : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal StateSpace(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(StateSpace obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~StateSpace() {
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
          ompl_basePINVOKE.delete_StateSpace(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public class SubstateLocation : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal SubstateLocation(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SubstateLocation obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~SubstateLocation() {
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
            ompl_basePINVOKE.delete_StateSpace_SubstateLocation(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
      }
    }
  
    public SWIGTYPE_p_std__vectorT_std__size_t_t chain {
      set {
        ompl_basePINVOKE.StateSpace_SubstateLocation_chain_set(swigCPtr, SWIGTYPE_p_std__vectorT_std__size_t_t.getCPtr(value));
        if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        global::System.IntPtr cPtr = ompl_basePINVOKE.StateSpace_SubstateLocation_chain_get(swigCPtr);
        SWIGTYPE_p_std__vectorT_std__size_t_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__vectorT_std__size_t_t(cPtr, false);
        if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
    public StateSpace space {
      set {
        ompl_basePINVOKE.StateSpace_SubstateLocation_space_set(swigCPtr, StateSpace.getCPtr(value));
        if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        global::System.IntPtr cPtr = ompl_basePINVOKE.StateSpace_SubstateLocation_space_get(swigCPtr);
        StateSpace ret = (cPtr == global::System.IntPtr.Zero) ? null : new StateSpace(cPtr, true);
        if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
    public SubstateLocation() : this(ompl_basePINVOKE.new_StateSpace_SubstateLocation(), true) {
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    }
  
  }

  public class ValueLocation : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal ValueLocation(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ValueLocation obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~ValueLocation() {
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
            ompl_basePINVOKE.delete_StateSpace_ValueLocation(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
      }
    }
  
    public StateSpace.SubstateLocation stateLocation {
      set {
        ompl_basePINVOKE.StateSpace_ValueLocation_stateLocation_set(swigCPtr, StateSpace.SubstateLocation.getCPtr(value));
        if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        global::System.IntPtr cPtr = ompl_basePINVOKE.StateSpace_ValueLocation_stateLocation_get(swigCPtr);
        StateSpace.SubstateLocation ret = (cPtr == global::System.IntPtr.Zero) ? null : new StateSpace.SubstateLocation(cPtr, false);
        if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
    public uint index {
      set {
        ompl_basePINVOKE.StateSpace_ValueLocation_index_set(swigCPtr, value);
        if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        uint ret = ompl_basePINVOKE.StateSpace_ValueLocation_index_get(swigCPtr);
        if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
    public ValueLocation() : this(ompl_basePINVOKE.new_StateSpace_ValueLocation(), true) {
      if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    }
  
  }

  public virtual bool isCompound() {
    bool ret = ompl_basePINVOKE.StateSpace_isCompound(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool isDiscrete() {
    bool ret = ompl_basePINVOKE.StateSpace_isDiscrete(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool isHybrid() {
    bool ret = ompl_basePINVOKE.StateSpace_isHybrid(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool isMetricSpace() {
    bool ret = ompl_basePINVOKE.StateSpace_isMetricSpace(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool hasSymmetricDistance() {
    bool ret = ompl_basePINVOKE.StateSpace_hasSymmetricDistance(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool hasSymmetricInterpolate() {
    bool ret = ompl_basePINVOKE.StateSpace_hasSymmetricInterpolate(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getName() {
    string ret = ompl_basePINVOKE.StateSpace_getName(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setName(string name) {
    ompl_basePINVOKE.StateSpace_setName(swigCPtr, name);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public int getType() {
    int ret = ompl_basePINVOKE.StateSpace_getType(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool includes(StateSpace other) {
    bool ret = ompl_basePINVOKE.StateSpace_includes__SWIG_0(swigCPtr, StateSpace.getCPtr(other));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool covers(StateSpace other) {
    bool ret = ompl_basePINVOKE.StateSpace_covers__SWIG_0(swigCPtr, StateSpace.getCPtr(other));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ParamSet params_() {
    ParamSet ret = new ParamSet(ompl_basePINVOKE.StateSpace_params___SWIG_0(swigCPtr), false);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getLongestValidSegmentFraction() {
    double ret = ompl_basePINVOKE.StateSpace_getLongestValidSegmentFraction(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void setLongestValidSegmentFraction(double segmentFraction) {
    ompl_basePINVOKE.StateSpace_setLongestValidSegmentFraction(swigCPtr, segmentFraction);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual uint validSegmentCount(State state1, State state2) {
    uint ret = ompl_basePINVOKE.StateSpace_validSegmentCount(swigCPtr, State.getCPtr(state1), State.getCPtr(state2));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void setValidSegmentCountFactor(uint factor) {
    ompl_basePINVOKE.StateSpace_setValidSegmentCountFactor(swigCPtr, factor);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual uint getValidSegmentCountFactor() {
    uint ret = ompl_basePINVOKE.StateSpace_getValidSegmentCountFactor(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getLongestValidSegmentLength() {
    double ret = ompl_basePINVOKE.StateSpace_getLongestValidSegmentLength(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void computeSignature(intVector signature) {
    ompl_basePINVOKE.StateSpace_computeSignature(swigCPtr, intVector.getCPtr(signature));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual uint getDimension() {
    uint ret = ompl_basePINVOKE.StateSpace_getDimension(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getMaximumExtent() {
    double ret = ompl_basePINVOKE.StateSpace_getMaximumExtent(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double getMeasure() {
    double ret = ompl_basePINVOKE.StateSpace_getMeasure(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void enforceBounds(State state) {
    ompl_basePINVOKE.StateSpace_enforceBounds(swigCPtr, State.getCPtr(state));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool satisfiesBounds(State state) {
    bool ret = ompl_basePINVOKE.StateSpace_satisfiesBounds(swigCPtr, State.getCPtr(state));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void copyState(State destination, State source) {
    ompl_basePINVOKE.StateSpace_copyState(swigCPtr, State.getCPtr(destination), State.getCPtr(source));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public State cloneState(State source) {
    global::System.IntPtr cPtr = ompl_basePINVOKE.StateSpace_cloneState(swigCPtr, State.getCPtr(source));
    State ret = (cPtr == global::System.IntPtr.Zero) ? null : new State(cPtr, false);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double distance(State state1, State state2) {
    double ret = ompl_basePINVOKE.StateSpace_distance(swigCPtr, State.getCPtr(state1), State.getCPtr(state2));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual uint getSerializationLength() {
    uint ret = ompl_basePINVOKE.StateSpace_getSerializationLength(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void serialize(SWIGTYPE_p_void serialization, State state) {
    ompl_basePINVOKE.StateSpace_serialize(swigCPtr, SWIGTYPE_p_void.getCPtr(serialization), State.getCPtr(state));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void deserialize(State state, SWIGTYPE_p_void serialization) {
    ompl_basePINVOKE.StateSpace_deserialize(swigCPtr, State.getCPtr(state), SWIGTYPE_p_void.getCPtr(serialization));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool equalStates(State state1, State state2) {
    bool ret = ompl_basePINVOKE.StateSpace_equalStates(swigCPtr, State.getCPtr(state1), State.getCPtr(state2));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void interpolate(State _from, State to, double t, State state) {
    ompl_basePINVOKE.StateSpace_interpolate(swigCPtr, State.getCPtr(_from), State.getCPtr(to), t, State.getCPtr(state));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual StateSampler allocDefaultStateSampler() {
    global::System.IntPtr cPtr = ompl_basePINVOKE.StateSpace_allocDefaultStateSampler(swigCPtr);
    StateSampler ret = (cPtr == global::System.IntPtr.Zero) ? null : new StateSampler(cPtr, true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual StateSampler allocStateSampler() {
    global::System.IntPtr cPtr = ompl_basePINVOKE.StateSpace_allocStateSampler(swigCPtr);
    StateSampler ret = (cPtr == global::System.IntPtr.Zero) ? null : new StateSampler(cPtr, true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setStateSamplerAllocator(SWIGTYPE_p_std__functionT_std__shared_ptrT_ompl__base__StateSampler_t_fompl__base__StateSpace_const_pF_t ssa) {
    ompl_basePINVOKE.StateSpace_setStateSamplerAllocator(swigCPtr, SWIGTYPE_p_std__functionT_std__shared_ptrT_ompl__base__StateSampler_t_fompl__base__StateSpace_const_pF_t.getCPtr(ssa));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void clearStateSamplerAllocator() {
    ompl_basePINVOKE.StateSpace_clearStateSamplerAllocator(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual State allocState() {
    global::System.IntPtr cPtr = ompl_basePINVOKE.StateSpace_allocState(swigCPtr);
    State ret = (cPtr == global::System.IntPtr.Zero) ? null : new State(cPtr, false);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void freeState(State state) {
    ompl_basePINVOKE.StateSpace_freeState(swigCPtr, State.getCPtr(state));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual SWIGTYPE_p_double getValueAddressAtIndex(State state, uint index) {
    global::System.IntPtr cPtr = ompl_basePINVOKE.StateSpace_getValueAddressAtIndex__SWIG_0(swigCPtr, State.getCPtr(state), index);
    SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__vectorT_ompl__base__StateSpace__ValueLocation_t getValueLocations() {
    SWIGTYPE_p_std__vectorT_ompl__base__StateSpace__ValueLocation_t ret = new SWIGTYPE_p_std__vectorT_ompl__base__StateSpace__ValueLocation_t(ompl_basePINVOKE.StateSpace_getValueLocations(swigCPtr), false);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__mapT_std__string_ompl__base__StateSpace__ValueLocation_t getValueLocationsByName() {
    SWIGTYPE_p_std__mapT_std__string_ompl__base__StateSpace__ValueLocation_t ret = new SWIGTYPE_p_std__mapT_std__string_ompl__base__StateSpace__ValueLocation_t(ompl_basePINVOKE.StateSpace_getValueLocationsByName(swigCPtr), false);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_double getValueAddressAtLocation(State state, StateSpace.ValueLocation loc) {
    global::System.IntPtr cPtr = ompl_basePINVOKE.StateSpace_getValueAddressAtLocation__SWIG_0(swigCPtr, State.getCPtr(state), StateSpace.ValueLocation.getCPtr(loc));
    SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_double getValueAddressAtName(State state, string name) {
    global::System.IntPtr cPtr = ompl_basePINVOKE.StateSpace_getValueAddressAtName__SWIG_0(swigCPtr, State.getCPtr(state), name);
    SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void copyToReals(doubleVector reals, State source) {
    ompl_basePINVOKE.StateSpace_copyToReals(swigCPtr, doubleVector.getCPtr(reals), State.getCPtr(source));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void copyFromReals(State destination, doubleVector reals) {
    ompl_basePINVOKE.StateSpace_copyFromReals(swigCPtr, State.getCPtr(destination), doubleVector.getCPtr(reals));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void registerProjection(string name, SWIGTYPE_p_std__shared_ptrT_ompl__base__ProjectionEvaluator_t projection) {
    ompl_basePINVOKE.StateSpace_registerProjection(swigCPtr, name, SWIGTYPE_p_std__shared_ptrT_ompl__base__ProjectionEvaluator_t.getCPtr(projection));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void registerDefaultProjection(SWIGTYPE_p_std__shared_ptrT_ompl__base__ProjectionEvaluator_t projection) {
    ompl_basePINVOKE.StateSpace_registerDefaultProjection(swigCPtr, SWIGTYPE_p_std__shared_ptrT_ompl__base__ProjectionEvaluator_t.getCPtr(projection));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void registerProjections() {
    ompl_basePINVOKE.StateSpace_registerProjections(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_std__shared_ptrT_ompl__base__ProjectionEvaluator_t getProjection(string name) {
    SWIGTYPE_p_std__shared_ptrT_ompl__base__ProjectionEvaluator_t ret = new SWIGTYPE_p_std__shared_ptrT_ompl__base__ProjectionEvaluator_t(ompl_basePINVOKE.StateSpace_getProjection(swigCPtr, name), true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__shared_ptrT_ompl__base__ProjectionEvaluator_t getDefaultProjection() {
    SWIGTYPE_p_std__shared_ptrT_ompl__base__ProjectionEvaluator_t ret = new SWIGTYPE_p_std__shared_ptrT_ompl__base__ProjectionEvaluator_t(ompl_basePINVOKE.StateSpace_getDefaultProjection(swigCPtr), true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool hasProjection(string name) {
    bool ret = ompl_basePINVOKE.StateSpace_hasProjection(swigCPtr, name);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool hasDefaultProjection() {
    bool ret = ompl_basePINVOKE.StateSpace_hasDefaultProjection(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__mapT_std__string_std__shared_ptrT_ompl__base__ProjectionEvaluator_t_t getRegisteredProjections() {
    SWIGTYPE_p_std__mapT_std__string_std__shared_ptrT_ompl__base__ProjectionEvaluator_t_t ret = new SWIGTYPE_p_std__mapT_std__string_std__shared_ptrT_ompl__base__ProjectionEvaluator_t_t(ompl_basePINVOKE.StateSpace_getRegisteredProjections(swigCPtr), false);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void printState(State state, SWIGTYPE_p_std__ostream _out) {
    ompl_basePINVOKE.StateSpace_printState__SWIG_0(swigCPtr, State.getCPtr(state), SWIGTYPE_p_std__ostream.getCPtr(_out));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void printState(State state) {
    ompl_basePINVOKE.StateSpace_printState__SWIG_1(swigCPtr, State.getCPtr(state));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void printSettings(SWIGTYPE_p_std__ostream _out) {
    ompl_basePINVOKE.StateSpace_printSettings(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(_out));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void printProjections(SWIGTYPE_p_std__ostream _out) {
    ompl_basePINVOKE.StateSpace_printProjections(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(_out));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void sanityChecks(double zero, double eps, uint flags) {
    ompl_basePINVOKE.StateSpace_sanityChecks__SWIG_0(swigCPtr, zero, eps, flags);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void sanityChecks() {
    ompl_basePINVOKE.StateSpace_sanityChecks__SWIG_1(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void diagram(SWIGTYPE_p_std__ostream _out) {
    ompl_basePINVOKE.StateSpace_diagram(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(_out));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public void list(SWIGTYPE_p_std__ostream _out) {
    ompl_basePINVOKE.StateSpace_list(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(_out));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public static void Diagram(SWIGTYPE_p_std__ostream _out) {
    ompl_basePINVOKE.StateSpace_Diagram(SWIGTYPE_p_std__ostream.getCPtr(_out));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public static void List(SWIGTYPE_p_std__ostream _out) {
    ompl_basePINVOKE.StateSpace_List(SWIGTYPE_p_std__ostream.getCPtr(_out));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public StateSampler allocSubspaceStateSampler(StateSpace subspace) {
    global::System.IntPtr cPtr = ompl_basePINVOKE.StateSpace_allocSubspaceStateSampler__SWIG_0(swigCPtr, StateSpace.getCPtr(subspace));
    StateSampler ret = (cPtr == global::System.IntPtr.Zero) ? null : new StateSampler(cPtr, true);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public State getSubstateAtLocation(State state, StateSpace.SubstateLocation loc) {
    global::System.IntPtr cPtr = ompl_basePINVOKE.StateSpace_getSubstateAtLocation__SWIG_0(swigCPtr, State.getCPtr(state), StateSpace.SubstateLocation.getCPtr(loc));
    State ret = (cPtr == global::System.IntPtr.Zero) ? null : new State(cPtr, false);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__mapT_std__string_ompl__base__StateSpace__SubstateLocation_t getSubstateLocationsByName() {
    SWIGTYPE_p_std__mapT_std__string_ompl__base__StateSpace__SubstateLocation_t ret = new SWIGTYPE_p_std__mapT_std__string_ompl__base__StateSpace__SubstateLocation_t(ompl_basePINVOKE.StateSpace_getSubstateLocationsByName(swigCPtr), false);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void getCommonSubspaces(StateSpace other, SWIGTYPE_p_std__vectorT_std__string_t subspaces) {
    ompl_basePINVOKE.StateSpace_getCommonSubspaces__SWIG_0(swigCPtr, StateSpace.getCPtr(other), SWIGTYPE_p_std__vectorT_std__string_t.getCPtr(subspaces));
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void computeLocations() {
    ompl_basePINVOKE.StateSpace_computeLocations(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setup() {
    ompl_basePINVOKE.StateSpace_setup(swigCPtr);
    if (ompl_basePINVOKE.SWIGPendingException.Pending) throw ompl_basePINVOKE.SWIGPendingException.Retrieve();
  }

  public enum SanityChecks {
    STATESPACE_DISTANCE_DIFFERENT_STATES = (1 << 1),
    STATESPACE_DISTANCE_SYMMETRIC = (1 << 2),
    STATESPACE_INTERPOLATION = (1 << 3),
    STATESPACE_TRIANGLE_INEQUALITY = (1 << 4),
    STATESPACE_DISTANCE_BOUND = (1 << 5),
    STATESPACE_RESPECT_BOUNDS = (1 << 6),
    STATESPACE_ENFORCE_BOUNDS_NO_OP = (1 << 7),
    STATESPACE_SERIALIZATION = (1 << 8)
  }

}

}
