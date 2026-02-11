using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Events
{
	// Token: 0x020001AB RID: 427
	[Serializable]
	public class PersistentCall : Object
	{
		// Token: 0x06001F5F RID: 8031 RVA: 0x0008C5D8 File Offset: 0x0008A7D8
		// Note: this type is marked as 'beforefieldinit'.
		static PersistentCall()
		{
			Il2CppClassPointerStore<PersistentCall>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "PersistentCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr);
			PersistentCall.NativeFieldInfoPtr_m_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, "m_Target");
			PersistentCall.NativeFieldInfoPtr_m_TargetAssemblyTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, "m_TargetAssemblyTypeName");
			PersistentCall.NativeFieldInfoPtr_m_MethodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, "m_MethodName");
			PersistentCall.NativeFieldInfoPtr_m_Mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, "m_Mode");
			PersistentCall.NativeFieldInfoPtr_m_Arguments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, "m_Arguments");
			PersistentCall.NativeFieldInfoPtr_m_CallState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, "m_CallState");
			PersistentCall.NativeMethodInfoPtr_get_target_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100667599);
			PersistentCall.NativeMethodInfoPtr_get_targetAssemblyTypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100667600);
			PersistentCall.NativeMethodInfoPtr_get_methodName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100667601);
			PersistentCall.NativeMethodInfoPtr_get_mode_Public_get_PersistentListenerMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100667602);
			PersistentCall.NativeMethodInfoPtr_get_arguments_Public_get_ArgumentCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100667603);
			PersistentCall.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100667604);
			PersistentCall.NativeMethodInfoPtr_GetRuntimeCall_Public_BaseInvokableCall_UnityEventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100667605);
			PersistentCall.NativeMethodInfoPtr_GetObjectCall_Private_Static_BaseInvokableCall_Object_MethodInfo_ArgumentCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100667606);
			PersistentCall.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100667607);
			PersistentCall.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100667608);
			PersistentCall.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100667609);
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06001F60 RID: 8032 RVA: 0x0008C75C File Offset: 0x0008A95C
		public unsafe Object target
		{
			[CallerCount(169)]
			[CachedScanResults(RefRangeStart = 282426, RefRangeEnd = 282595, XrefRangeStart = 282426, XrefRangeEnd = 282595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_get_target_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06001F61 RID: 8033 RVA: 0x0008C79C File Offset: 0x0008A99C
		public unsafe string targetAssemblyTypeName
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 678447, RefRangeEnd = 678450, XrefRangeStart = 678439, XrefRangeEnd = 678447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_get_targetAssemblyTypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06001F62 RID: 8034 RVA: 0x0008C7D4 File Offset: 0x0008A9D4
		public unsafe string methodName
		{
			[CallerCount(35)]
			[CachedScanResults(RefRangeStart = 337628, RefRangeEnd = 337663, XrefRangeStart = 337628, XrefRangeEnd = 337663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_get_methodName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06001F63 RID: 8035 RVA: 0x0008C80C File Offset: 0x0008AA0C
		// (set) Token: 0x06001F78 RID: 8056 RVA: 0x0000BEFB File Offset: 0x0000A0FB
		public unsafe PersistentListenerMode mode
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 678450, RefRangeEnd = 678472, XrefRangeStart = 678450, XrefRangeEnd = 678450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_get_mode_Public_get_PersistentListenerMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Mode = value;
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06001F64 RID: 8036 RVA: 0x0008C848 File Offset: 0x0008AA48
		public unsafe ArgumentCache arguments
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_get_arguments_Public_get_ArgumentCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArgumentCache>(intPtr3) : null;
			}
		}

		// Token: 0x06001F65 RID: 8037 RVA: 0x0008C888 File Offset: 0x0008AA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 678472, XrefRangeEnd = 678474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_IsValid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F66 RID: 8038 RVA: 0x0008C8C4 File Offset: 0x0008AAC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 678518, RefRangeEnd = 678519, XrefRangeStart = 678474, XrefRangeEnd = 678518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(theEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_GetRuntimeCall_Public_BaseInvokableCall_UnityEventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInvokableCall>(intPtr3) : null;
			}
		}

		// Token: 0x06001F67 RID: 8039 RVA: 0x0008C914 File Offset: 0x0008AB14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 678580, RefRangeEnd = 678581, XrefRangeStart = 678519, XrefRangeEnd = 678580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BaseInvokableCall GetObjectCall(Object target, MethodInfo method, ArgumentCache arguments)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_GetObjectCall_Private_Static_BaseInvokableCall_Object_MethodInfo_ArgumentCache_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInvokableCall>(intPtr3) : null;
		}

		// Token: 0x06001F68 RID: 8040 RVA: 0x0008C97C File Offset: 0x0008AB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F69 RID: 8041 RVA: 0x0008C9B0 File Offset: 0x0008ABB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x0008C9E4 File Offset: 0x0008ABE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 678581, XrefRangeEnd = 678587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PersistentCall()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x0000BE40 File Offset: 0x0000A040
		public PersistentCall(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06001F6C RID: 8044 RVA: 0x0008CA20 File Offset: 0x0008AC20
		// (set) Token: 0x06001F6D RID: 8045 RVA: 0x0000BE49 File Offset: 0x0000A049
		public unsafe Object m_Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06001F6E RID: 8046 RVA: 0x0008CA50 File Offset: 0x0008AC50
		// (set) Token: 0x06001F6F RID: 8047 RVA: 0x0000BE68 File Offset: 0x0000A068
		public unsafe string m_TargetAssemblyTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_TargetAssemblyTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_TargetAssemblyTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06001F70 RID: 8048 RVA: 0x0008CA78 File Offset: 0x0008AC78
		// (set) Token: 0x06001F71 RID: 8049 RVA: 0x0000BE87 File Offset: 0x0000A087
		public unsafe string m_MethodName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_MethodName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_MethodName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06001F72 RID: 8050 RVA: 0x0008CAA0 File Offset: 0x0008ACA0
		// (set) Token: 0x06001F73 RID: 8051 RVA: 0x0000BEA6 File Offset: 0x0000A0A6
		public unsafe PersistentListenerMode m_Mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_Mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_Mode)) = value;
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001F74 RID: 8052 RVA: 0x0008CAC8 File Offset: 0x0008ACC8
		// (set) Token: 0x06001F75 RID: 8053 RVA: 0x0000BEC1 File Offset: 0x0000A0C1
		public unsafe ArgumentCache m_Arguments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_Arguments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArgumentCache>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_Arguments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06001F76 RID: 8054 RVA: 0x0008CAF8 File Offset: 0x0008ACF8
		// (set) Token: 0x06001F77 RID: 8055 RVA: 0x0000BEE0 File Offset: 0x0000A0E0
		public unsafe UnityEventCallState m_CallState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_CallState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_CallState)) = value;
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001F79 RID: 8057 RVA: 0x0008CB20 File Offset: 0x0008AD20
		// (set) Token: 0x06001F7A RID: 8058 RVA: 0x0000BF05 File Offset: 0x0000A105
		public UnityEventCallState callState
		{
			get
			{
				return this.m_CallState;
			}
			set
			{
				this.m_CallState = value;
			}
		}

		// Token: 0x06001F7B RID: 8059 RVA: 0x0000BF0F File Offset: 0x0000A10F
		public void RegisterPersistentListener(Object ttarget, Type targetType, string mmethodName)
		{
			this.m_Target = ttarget;
			this.m_TargetAssemblyTypeName = UnityEventTools.TidyAssemblyTypeName(targetType.AssemblyQualifiedName);
			this.m_MethodName = mmethodName;
		}

		// Token: 0x06001F7C RID: 8060 RVA: 0x0000BF31 File Offset: 0x0000A131
		public void UnregisterPersistentListener()
		{
			this.m_MethodName = String.Empty;
			this.m_Target = null;
			this.m_TargetAssemblyTypeName = String.Empty;
		}

		// Token: 0x04001B5A RID: 7002
		private static readonly IntPtr NativeFieldInfoPtr_m_Target;

		// Token: 0x04001B5B RID: 7003
		private static readonly IntPtr NativeFieldInfoPtr_m_TargetAssemblyTypeName;

		// Token: 0x04001B5C RID: 7004
		private static readonly IntPtr NativeFieldInfoPtr_m_MethodName;

		// Token: 0x04001B5D RID: 7005
		private static readonly IntPtr NativeFieldInfoPtr_m_Mode;

		// Token: 0x04001B5E RID: 7006
		private static readonly IntPtr NativeFieldInfoPtr_m_Arguments;

		// Token: 0x04001B5F RID: 7007
		private static readonly IntPtr NativeFieldInfoPtr_m_CallState;

		// Token: 0x04001B60 RID: 7008
		private static readonly IntPtr NativeMethodInfoPtr_get_target_Public_get_Object_0;

		// Token: 0x04001B61 RID: 7009
		private static readonly IntPtr NativeMethodInfoPtr_get_targetAssemblyTypeName_Public_get_String_0;

		// Token: 0x04001B62 RID: 7010
		private static readonly IntPtr NativeMethodInfoPtr_get_methodName_Public_get_String_0;

		// Token: 0x04001B63 RID: 7011
		private static readonly IntPtr NativeMethodInfoPtr_get_mode_Public_get_PersistentListenerMode_0;

		// Token: 0x04001B64 RID: 7012
		private static readonly IntPtr NativeMethodInfoPtr_get_arguments_Public_get_ArgumentCache_0;

		// Token: 0x04001B65 RID: 7013
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

		// Token: 0x04001B66 RID: 7014
		private static readonly IntPtr NativeMethodInfoPtr_GetRuntimeCall_Public_BaseInvokableCall_UnityEventBase_0;

		// Token: 0x04001B67 RID: 7015
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectCall_Private_Static_BaseInvokableCall_Object_MethodInfo_ArgumentCache_0;

		// Token: 0x04001B68 RID: 7016
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001B69 RID: 7017
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001B6A RID: 7018
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
