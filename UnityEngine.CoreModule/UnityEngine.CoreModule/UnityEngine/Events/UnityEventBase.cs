using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.Events
{
	// Token: 0x020001AE RID: 430
	[Serializable]
	public class UnityEventBase : Object
	{
		// Token: 0x06001FA5 RID: 8101 RVA: 0x0008D2B4 File Offset: 0x0008B4B4
		// Note: this type is marked as 'beforefieldinit'.
		static UnityEventBase()
		{
			Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "UnityEventBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr);
			UnityEventBase.NativeFieldInfoPtr_m_Calls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, "m_Calls");
			UnityEventBase.NativeFieldInfoPtr_m_PersistentCalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, "m_PersistentCalls");
			UnityEventBase.NativeFieldInfoPtr_m_CallsDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, "m_CallsDirty");
			UnityEventBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100667620);
			UnityEventBase.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100667621);
			UnityEventBase.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100667622);
			UnityEventBase.NativeMethodInfoPtr_FindMethod_Impl_Protected_Abstract_Virtual_New_MethodInfo_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100667623);
			UnityEventBase.NativeMethodInfoPtr_GetDelegate_Internal_Abstract_Virtual_New_BaseInvokableCall_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100667624);
			UnityEventBase.NativeMethodInfoPtr_FindMethod_Internal_MethodInfo_PersistentCall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100667625);
			UnityEventBase.NativeMethodInfoPtr_FindMethod_Internal_MethodInfo_String_Type_PersistentListenerMode_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100667626);
			UnityEventBase.NativeMethodInfoPtr_GetCallsCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100667627);
			UnityEventBase.NativeMethodInfoPtr_DirtyPersistentCalls_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100667628);
			UnityEventBase.NativeMethodInfoPtr_RebuildPersistentCallsIfNeeded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100667629);
			UnityEventBase.NativeMethodInfoPtr_AddCall_Internal_Void_BaseInvokableCall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100667630);
			UnityEventBase.NativeMethodInfoPtr_RemoveListener_Protected_Void_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100667631);
			UnityEventBase.NativeMethodInfoPtr_RemoveAllListeners_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100667632);
			UnityEventBase.NativeMethodInfoPtr_PrepareInvoke_Internal_List_1_BaseInvokableCall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100667633);
			UnityEventBase.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100667634);
			UnityEventBase.NativeMethodInfoPtr_GetValidMethodInfo_Public_Static_MethodInfo_Type_String_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100667635);
		}

		// Token: 0x06001FA6 RID: 8102 RVA: 0x0008D460 File Offset: 0x0008B660
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 678739, RefRangeEnd = 678743, XrefRangeStart = 678704, XrefRangeEnd = 678739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEventBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FA7 RID: 8103 RVA: 0x0008D49C File Offset: 0x0008B69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 678743, XrefRangeEnd = 678744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FA8 RID: 8104 RVA: 0x0008D4D0 File Offset: 0x0008B6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FA9 RID: 8105 RVA: 0x0008D504 File Offset: 0x0008B704
		[CallerCount(0)]
		public unsafe virtual MethodInfo FindMethod_Impl(string name, Type targetObjType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetObjType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityEventBase.NativeMethodInfoPtr_FindMethod_Impl_Protected_Abstract_Virtual_New_MethodInfo_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06001FAA RID: 8106 RVA: 0x0008D574 File Offset: 0x0008B774
		[CallerCount(0)]
		public unsafe virtual BaseInvokableCall GetDelegate(Object target, MethodInfo theFunction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(theFunction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityEventBase.NativeMethodInfoPtr_GetDelegate_Internal_Abstract_Virtual_New_BaseInvokableCall_Object_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInvokableCall>(intPtr3) : null;
		}

		// Token: 0x06001FAB RID: 8107 RVA: 0x0008D5E4 File Offset: 0x0008B7E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 678775, RefRangeEnd = 678776, XrefRangeStart = 678744, XrefRangeEnd = 678775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodInfo FindMethod(PersistentCall call)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(call);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_FindMethod_Internal_MethodInfo_PersistentCall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001FAC RID: 8108 RVA: 0x0008D634 File Offset: 0x0008B834
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 678830, RefRangeEnd = 678831, XrefRangeStart = 678776, XrefRangeEnd = 678830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodInfo FindMethod(string name, Type listenerType, PersistentListenerMode mode, Type argumentType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listenerType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argumentType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_FindMethod_Internal_MethodInfo_String_Type_PersistentListenerMode_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06001FAD RID: 8109 RVA: 0x0008D6B8 File Offset: 0x0008B8B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 678831, XrefRangeEnd = 678832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCallsCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_GetCallsCount_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FAE RID: 8110 RVA: 0x0008D6F4 File Offset: 0x0008B8F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 678841, RefRangeEnd = 678843, XrefRangeStart = 678832, XrefRangeEnd = 678841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DirtyPersistentCalls()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_DirtyPersistentCalls_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FAF RID: 8111 RVA: 0x0008D728 File Offset: 0x0008B928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 678843, XrefRangeEnd = 678844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RebuildPersistentCallsIfNeeded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_RebuildPersistentCallsIfNeeded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FB0 RID: 8112 RVA: 0x0008D75C File Offset: 0x0008B95C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 678847, RefRangeEnd = 678851, XrefRangeStart = 678844, XrefRangeEnd = 678847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCall(BaseInvokableCall call)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(call);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_AddCall_Internal_Void_BaseInvokableCall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FB1 RID: 8113 RVA: 0x0008D7A0 File Offset: 0x0008B9A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 678853, RefRangeEnd = 678855, XrefRangeStart = 678851, XrefRangeEnd = 678853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveListener(Object targetObj, MethodInfo method)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_RemoveListener_Protected_Void_Object_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FB2 RID: 8114 RVA: 0x0008D7F4 File Offset: 0x0008B9F4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 678864, RefRangeEnd = 678877, XrefRangeStart = 678855, XrefRangeEnd = 678864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAllListeners()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_RemoveAllListeners_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FB3 RID: 8115 RVA: 0x0008D828 File Offset: 0x0008BA28
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 678885, RefRangeEnd = 678888, XrefRangeStart = 678877, XrefRangeEnd = 678885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<BaseInvokableCall> PrepareInvoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_PrepareInvoke_Internal_List_1_BaseInvokableCall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<BaseInvokableCall>>(intPtr3) : null;
		}

		// Token: 0x06001FB4 RID: 8116 RVA: 0x0008D868 File Offset: 0x0008BA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 678888, XrefRangeEnd = 678894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityEventBase.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001FB5 RID: 8117 RVA: 0x0008D8AC File Offset: 0x0008BAAC
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 678910, RefRangeEnd = 678927, XrefRangeStart = 678894, XrefRangeEnd = 678910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodInfo GetValidMethodInfo(Type objectType, string functionName, Il2CppReferenceArray<Type> argumentTypes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(functionName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argumentTypes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_GetValidMethodInfo_Public_Static_MethodInfo_Type_String_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06001FB6 RID: 8118 RVA: 0x0000C03D File Offset: 0x0000A23D
		public UnityEventBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06001FB7 RID: 8119 RVA: 0x0008D914 File Offset: 0x0008BB14
		// (set) Token: 0x06001FB8 RID: 8120 RVA: 0x0000C046 File Offset: 0x0000A246
		public unsafe InvokableCallList m_Calls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEventBase.NativeFieldInfoPtr_m_Calls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InvokableCallList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEventBase.NativeFieldInfoPtr_m_Calls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06001FB9 RID: 8121 RVA: 0x0008D944 File Offset: 0x0008BB44
		// (set) Token: 0x06001FBA RID: 8122 RVA: 0x0000C065 File Offset: 0x0000A265
		public unsafe PersistentCallGroup m_PersistentCalls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEventBase.NativeFieldInfoPtr_m_PersistentCalls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PersistentCallGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEventBase.NativeFieldInfoPtr_m_PersistentCalls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06001FBB RID: 8123 RVA: 0x0008D974 File Offset: 0x0008BB74
		// (set) Token: 0x06001FBC RID: 8124 RVA: 0x0000C084 File Offset: 0x0000A284
		public unsafe bool m_CallsDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEventBase.NativeFieldInfoPtr_m_CallsDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEventBase.NativeFieldInfoPtr_m_CallsDirty)) = value;
			}
		}

		// Token: 0x06001FBD RID: 8125 RVA: 0x0008D99C File Offset: 0x0008BB9C
		public MethodInfo FindMethod_Impl(string name, Object targetObj)
		{
			return this.FindMethod_Impl(name, targetObj.GetType());
		}

		// Token: 0x06001FBE RID: 8126 RVA: 0x0008D9BC File Offset: 0x0008BBBC
		public int GetPersistentEventCount()
		{
			return this.m_PersistentCalls.Count;
		}

		// Token: 0x06001FBF RID: 8127 RVA: 0x0008D9DC File Offset: 0x0008BBDC
		public Object GetPersistentTarget(int index)
		{
			PersistentCall listener = this.m_PersistentCalls.GetListener(index);
			return (listener != null) ? listener.target : null;
		}

		// Token: 0x06001FC0 RID: 8128 RVA: 0x0008DA08 File Offset: 0x0008BC08
		public string GetPersistentMethodName(int index)
		{
			PersistentCall listener = this.m_PersistentCalls.GetListener(index);
			return (listener != null) ? listener.methodName : String.Empty;
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x0008DA38 File Offset: 0x0008BC38
		public void SetPersistentListenerState(int index, UnityEventCallState state)
		{
			PersistentCall listener = this.m_PersistentCalls.GetListener(index);
			bool flag = listener != null;
			if (flag)
			{
				listener.callState = state;
			}
			this.DirtyPersistentCalls();
		}

		// Token: 0x06001FC2 RID: 8130 RVA: 0x0008DA6C File Offset: 0x0008BC6C
		public UnityEventCallState GetPersistentListenerState(int index)
		{
			bool flag = index < 0 || index > this.m_PersistentCalls.Count;
			if (flag)
			{
				throw new IndexOutOfRangeException(String.Format("Index {0} is out of range of the {1} persistent listeners.", index, this.GetPersistentEventCount()));
			}
			return this.m_PersistentCalls.GetListener(index).callState;
		}

		// Token: 0x06001FC3 RID: 8131 RVA: 0x0000C09F File Offset: 0x0000A29F
		public void AddListener(Object targetObj, MethodInfo method)
		{
			this.m_Calls.AddListener(this.GetDelegate(targetObj, method));
		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x0008DACC File Offset: 0x0008BCCC
		public void Invoke(Il2CppReferenceArray<Object> parameters)
		{
			List<BaseInvokableCall> list = this.PrepareInvoke();
			for (int i = 0; i < list.Count; i++)
			{
				list[i].Invoke(parameters);
			}
		}

		// Token: 0x06001FC5 RID: 8133 RVA: 0x0008DB04 File Offset: 0x0008BD04
		public static MethodInfo GetValidMethodInfo(Object obj, string functionName, Il2CppReferenceArray<Type> argumentTypes)
		{
			return UnityEventBase.GetValidMethodInfo(obj.GetType(), functionName, argumentTypes);
		}

		// Token: 0x04001B7A RID: 7034
		private static readonly IntPtr NativeFieldInfoPtr_m_Calls;

		// Token: 0x04001B7B RID: 7035
		private static readonly IntPtr NativeFieldInfoPtr_m_PersistentCalls;

		// Token: 0x04001B7C RID: 7036
		private static readonly IntPtr NativeFieldInfoPtr_m_CallsDirty;

		// Token: 0x04001B7D RID: 7037
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001B7E RID: 7038
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001B7F RID: 7039
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001B80 RID: 7040
		private static readonly IntPtr NativeMethodInfoPtr_FindMethod_Impl_Protected_Abstract_Virtual_New_MethodInfo_String_Type_0;

		// Token: 0x04001B81 RID: 7041
		private static readonly IntPtr NativeMethodInfoPtr_GetDelegate_Internal_Abstract_Virtual_New_BaseInvokableCall_Object_MethodInfo_0;

		// Token: 0x04001B82 RID: 7042
		private static readonly IntPtr NativeMethodInfoPtr_FindMethod_Internal_MethodInfo_PersistentCall_0;

		// Token: 0x04001B83 RID: 7043
		private static readonly IntPtr NativeMethodInfoPtr_FindMethod_Internal_MethodInfo_String_Type_PersistentListenerMode_Type_0;

		// Token: 0x04001B84 RID: 7044
		private static readonly IntPtr NativeMethodInfoPtr_GetCallsCount_Internal_Int32_0;

		// Token: 0x04001B85 RID: 7045
		private static readonly IntPtr NativeMethodInfoPtr_DirtyPersistentCalls_Private_Void_0;

		// Token: 0x04001B86 RID: 7046
		private static readonly IntPtr NativeMethodInfoPtr_RebuildPersistentCallsIfNeeded_Private_Void_0;

		// Token: 0x04001B87 RID: 7047
		private static readonly IntPtr NativeMethodInfoPtr_AddCall_Internal_Void_BaseInvokableCall_0;

		// Token: 0x04001B88 RID: 7048
		private static readonly IntPtr NativeMethodInfoPtr_RemoveListener_Protected_Void_Object_MethodInfo_0;

		// Token: 0x04001B89 RID: 7049
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAllListeners_Public_Void_0;

		// Token: 0x04001B8A RID: 7050
		private static readonly IntPtr NativeMethodInfoPtr_PrepareInvoke_Internal_List_1_BaseInvokableCall_0;

		// Token: 0x04001B8B RID: 7051
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001B8C RID: 7052
		private static readonly IntPtr NativeMethodInfoPtr_GetValidMethodInfo_Public_Static_MethodInfo_Type_String_Il2CppReferenceArray_1_Type_0;
	}
}
