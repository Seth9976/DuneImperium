using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.Events
{
	// Token: 0x020001AD RID: 429
	public class InvokableCallList : Object
	{
		// Token: 0x06001F93 RID: 8083 RVA: 0x0008CEE0 File Offset: 0x0008B0E0
		// Note: this type is marked as 'beforefieldinit'.
		static InvokableCallList()
		{
			Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "InvokableCallList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr);
			InvokableCallList.NativeFieldInfoPtr_m_PersistentCalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, "m_PersistentCalls");
			InvokableCallList.NativeFieldInfoPtr_m_RuntimeCalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, "m_RuntimeCalls");
			InvokableCallList.NativeFieldInfoPtr_m_ExecutingCalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, "m_ExecutingCalls");
			InvokableCallList.NativeFieldInfoPtr_m_NeedsUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, "m_NeedsUpdate");
			InvokableCallList.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, 100667612);
			InvokableCallList.NativeMethodInfoPtr_AddPersistentInvokableCall_Public_Void_BaseInvokableCall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, 100667613);
			InvokableCallList.NativeMethodInfoPtr_AddListener_Public_Void_BaseInvokableCall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, 100667614);
			InvokableCallList.NativeMethodInfoPtr_RemoveListener_Public_Void_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, 100667615);
			InvokableCallList.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, 100667616);
			InvokableCallList.NativeMethodInfoPtr_ClearPersistent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, 100667617);
			InvokableCallList.NativeMethodInfoPtr_PrepareInvoke_Public_List_1_BaseInvokableCall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, 100667618);
			InvokableCallList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, 100667619);
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06001F94 RID: 8084 RVA: 0x0008D000 File Offset: 0x0008B200
		public unsafe int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 678617, XrefRangeEnd = 678618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCallList.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x0008D03C File Offset: 0x0008B23C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 678621, RefRangeEnd = 678622, XrefRangeStart = 678618, XrefRangeEnd = 678621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPersistentInvokableCall(BaseInvokableCall call)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(call);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCallList.NativeMethodInfoPtr_AddPersistentInvokableCall_Public_Void_BaseInvokableCall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x0008D080 File Offset: 0x0008B280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 678622, XrefRangeEnd = 678625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddListener(BaseInvokableCall call)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(call);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCallList.NativeMethodInfoPtr_AddListener_Public_Void_BaseInvokableCall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x0008D0C4 File Offset: 0x0008B2C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 678659, RefRangeEnd = 678661, XrefRangeStart = 678625, XrefRangeEnd = 678659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCallList.NativeMethodInfoPtr_RemoveListener_Public_Void_Object_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x0008D118 File Offset: 0x0008B318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 678661, XrefRangeEnd = 678670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCallList.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F99 RID: 8089 RVA: 0x0008D14C File Offset: 0x0008B34C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 678670, XrefRangeEnd = 678679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearPersistent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCallList.NativeMethodInfoPtr_ClearPersistent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F9A RID: 8090 RVA: 0x0008D180 File Offset: 0x0008B380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 678679, XrefRangeEnd = 678686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<BaseInvokableCall> PrepareInvoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCallList.NativeMethodInfoPtr_PrepareInvoke_Public_List_1_BaseInvokableCall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<BaseInvokableCall>>(intPtr3) : null;
		}

		// Token: 0x06001F9B RID: 8091 RVA: 0x0008D1C0 File Offset: 0x0008B3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 678686, XrefRangeEnd = 678704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvokableCallList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCallList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F9C RID: 8092 RVA: 0x0000BFBC File Offset: 0x0000A1BC
		public InvokableCallList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06001F9D RID: 8093 RVA: 0x0008D1FC File Offset: 0x0008B3FC
		// (set) Token: 0x06001F9E RID: 8094 RVA: 0x0000BFC5 File Offset: 0x0000A1C5
		public unsafe List<BaseInvokableCall> m_PersistentCalls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCallList.NativeFieldInfoPtr_m_PersistentCalls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BaseInvokableCall>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCallList.NativeFieldInfoPtr_m_PersistentCalls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06001F9F RID: 8095 RVA: 0x0008D22C File Offset: 0x0008B42C
		// (set) Token: 0x06001FA0 RID: 8096 RVA: 0x0000BFE4 File Offset: 0x0000A1E4
		public unsafe List<BaseInvokableCall> m_RuntimeCalls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCallList.NativeFieldInfoPtr_m_RuntimeCalls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BaseInvokableCall>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCallList.NativeFieldInfoPtr_m_RuntimeCalls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06001FA1 RID: 8097 RVA: 0x0008D25C File Offset: 0x0008B45C
		// (set) Token: 0x06001FA2 RID: 8098 RVA: 0x0000C003 File Offset: 0x0000A203
		public unsafe List<BaseInvokableCall> m_ExecutingCalls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCallList.NativeFieldInfoPtr_m_ExecutingCalls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BaseInvokableCall>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCallList.NativeFieldInfoPtr_m_ExecutingCalls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06001FA3 RID: 8099 RVA: 0x0008D28C File Offset: 0x0008B48C
		// (set) Token: 0x06001FA4 RID: 8100 RVA: 0x0000C022 File Offset: 0x0000A222
		public unsafe bool m_NeedsUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCallList.NativeFieldInfoPtr_m_NeedsUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCallList.NativeFieldInfoPtr_m_NeedsUpdate)) = value;
			}
		}

		// Token: 0x04001B6E RID: 7022
		private static readonly IntPtr NativeFieldInfoPtr_m_PersistentCalls;

		// Token: 0x04001B6F RID: 7023
		private static readonly IntPtr NativeFieldInfoPtr_m_RuntimeCalls;

		// Token: 0x04001B70 RID: 7024
		private static readonly IntPtr NativeFieldInfoPtr_m_ExecutingCalls;

		// Token: 0x04001B71 RID: 7025
		private static readonly IntPtr NativeFieldInfoPtr_m_NeedsUpdate;

		// Token: 0x04001B72 RID: 7026
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04001B73 RID: 7027
		private static readonly IntPtr NativeMethodInfoPtr_AddPersistentInvokableCall_Public_Void_BaseInvokableCall_0;

		// Token: 0x04001B74 RID: 7028
		private static readonly IntPtr NativeMethodInfoPtr_AddListener_Public_Void_BaseInvokableCall_0;

		// Token: 0x04001B75 RID: 7029
		private static readonly IntPtr NativeMethodInfoPtr_RemoveListener_Public_Void_Object_MethodInfo_0;

		// Token: 0x04001B76 RID: 7030
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04001B77 RID: 7031
		private static readonly IntPtr NativeMethodInfoPtr_ClearPersistent_Public_Void_0;

		// Token: 0x04001B78 RID: 7032
		private static readonly IntPtr NativeMethodInfoPtr_PrepareInvoke_Public_List_1_BaseInvokableCall_0;

		// Token: 0x04001B79 RID: 7033
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
