using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020002C8 RID: 712
	[Serializable]
	public class CrossAppDomainData : Object
	{
		// Token: 0x06002D06 RID: 11526 RVA: 0x000EB35C File Offset: 0x000E955C
		// Note: this type is marked as 'beforefieldinit'.
		static CrossAppDomainData()
		{
			Il2CppClassPointerStore<CrossAppDomainData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "CrossAppDomainData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrossAppDomainData>.NativeClassPtr);
			CrossAppDomainData.NativeFieldInfoPtr__ContextID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossAppDomainData>.NativeClassPtr, "_ContextID");
			CrossAppDomainData.NativeFieldInfoPtr__DomainID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossAppDomainData>.NativeClassPtr, "_DomainID");
			CrossAppDomainData.NativeFieldInfoPtr__processGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossAppDomainData>.NativeClassPtr, "_processGuid");
			CrossAppDomainData.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainData>.NativeClassPtr, 100670540);
			CrossAppDomainData.NativeMethodInfoPtr_get_DomainID_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainData>.NativeClassPtr, 100670541);
			CrossAppDomainData.NativeMethodInfoPtr_get_ProcessID_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossAppDomainData>.NativeClassPtr, 100670542);
		}

		// Token: 0x06002D07 RID: 11527 RVA: 0x000EB404 File Offset: 0x000E9604
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1381578, RefRangeEnd = 1381579, XrefRangeStart = 1381568, XrefRangeEnd = 1381578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CrossAppDomainData(int domainId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrossAppDomainData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref domainId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossAppDomainData.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06002D08 RID: 11528 RVA: 0x000EB44C File Offset: 0x000E964C
		public unsafe int DomainID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossAppDomainData.NativeMethodInfoPtr_get_DomainID_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06002D09 RID: 11529 RVA: 0x000EB488 File Offset: 0x000E9688
		public unsafe string ProcessID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossAppDomainData.NativeMethodInfoPtr_get_ProcessID_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002D0A RID: 11530 RVA: 0x0000F194 File Offset: 0x0000D394
		public CrossAppDomainData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06002D0B RID: 11531 RVA: 0x000EB4C0 File Offset: 0x000E96C0
		// (set) Token: 0x06002D0C RID: 11532 RVA: 0x0000F19D File Offset: 0x0000D39D
		public unsafe Object _ContextID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainData.NativeFieldInfoPtr__ContextID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainData.NativeFieldInfoPtr__ContextID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06002D0D RID: 11533 RVA: 0x000EB4F0 File Offset: 0x000E96F0
		// (set) Token: 0x06002D0E RID: 11534 RVA: 0x0000F1BC File Offset: 0x0000D3BC
		public unsafe int _DomainID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainData.NativeFieldInfoPtr__DomainID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainData.NativeFieldInfoPtr__DomainID)) = value;
			}
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06002D0F RID: 11535 RVA: 0x000EB518 File Offset: 0x000E9718
		// (set) Token: 0x06002D10 RID: 11536 RVA: 0x0000F1D7 File Offset: 0x0000D3D7
		public unsafe string _processGuid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainData.NativeFieldInfoPtr__processGuid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossAppDomainData.NativeFieldInfoPtr__processGuid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040025DA RID: 9690
		private static readonly IntPtr NativeFieldInfoPtr__ContextID;

		// Token: 0x040025DB RID: 9691
		private static readonly IntPtr NativeFieldInfoPtr__DomainID;

		// Token: 0x040025DC RID: 9692
		private static readonly IntPtr NativeFieldInfoPtr__processGuid;

		// Token: 0x040025DD RID: 9693
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x040025DE RID: 9694
		private static readonly IntPtr NativeMethodInfoPtr_get_DomainID_Internal_get_Int32_0;

		// Token: 0x040025DF RID: 9695
		private static readonly IntPtr NativeMethodInfoPtr_get_ProcessID_Internal_get_String_0;
	}
}
