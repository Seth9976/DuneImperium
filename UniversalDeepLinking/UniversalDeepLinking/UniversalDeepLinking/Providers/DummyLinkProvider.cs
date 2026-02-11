using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace ImaginationOverflow.UniversalDeepLinking.Providers
{
	// Token: 0x02000014 RID: 20
	public class DummyLinkProvider : Object
	{
		// Token: 0x060000F3 RID: 243 RVA: 0x00005E4C File Offset: 0x0000404C
		// Note: this type is marked as 'beforefieldinit'.
		static DummyLinkProvider()
		{
			Il2CppClassPointerStore<DummyLinkProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UniversalDeepLinking.dll", "ImaginationOverflow.UniversalDeepLinking.Providers", "DummyLinkProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DummyLinkProvider>.NativeClassPtr);
			DummyLinkProvider.NativeFieldInfoPtr_LinkReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DummyLinkProvider>.NativeClassPtr, "LinkReceived");
			DummyLinkProvider.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DummyLinkProvider>.NativeClassPtr, 100663461);
			DummyLinkProvider.NativeMethodInfoPtr_add_LinkReceived_Public_Virtual_Final_New_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DummyLinkProvider>.NativeClassPtr, 100663462);
			DummyLinkProvider.NativeMethodInfoPtr_remove_LinkReceived_Public_Virtual_Final_New_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DummyLinkProvider>.NativeClassPtr, 100663463);
			DummyLinkProvider.NativeMethodInfoPtr_PollInfoAfterPause_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DummyLinkProvider>.NativeClassPtr, 100663464);
			DummyLinkProvider.NativeMethodInfoPtr_OnLinkReceived_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DummyLinkProvider>.NativeClassPtr, 100663465);
			DummyLinkProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DummyLinkProvider>.NativeClassPtr, 100663466);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00005F08 File Offset: 0x00004108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241198, XrefRangeEnd = 1241204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DummyLinkProvider.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00005F44 File Offset: 0x00004144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241204, XrefRangeEnd = 1241209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_LinkReceived(Action<string> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DummyLinkProvider.NativeMethodInfoPtr_add_LinkReceived_Public_Virtual_Final_New_add_Void_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00005F88 File Offset: 0x00004188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241209, XrefRangeEnd = 1241214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_LinkReceived(Action<string> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DummyLinkProvider.NativeMethodInfoPtr_remove_LinkReceived_Public_Virtual_Final_New_rem_Void_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00005FCC File Offset: 0x000041CC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PollInfoAfterPause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DummyLinkProvider.NativeMethodInfoPtr_PollInfoAfterPause_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00006000 File Offset: 0x00004200
		[CallerCount(0)]
		public unsafe virtual void OnLinkReceived(string obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DummyLinkProvider.NativeMethodInfoPtr_OnLinkReceived_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00006050 File Offset: 0x00004250
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DummyLinkProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DummyLinkProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DummyLinkProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002568 File Offset: 0x00000768
		public DummyLinkProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000FB RID: 251 RVA: 0x0000608C File Offset: 0x0000428C
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00002571 File Offset: 0x00000771
		public unsafe Action<string> LinkReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DummyLinkProvider.NativeFieldInfoPtr_LinkReceived);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DummyLinkProvider.NativeFieldInfoPtr_LinkReceived), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeFieldInfoPtr_LinkReceived;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_add_LinkReceived_Public_Virtual_Final_New_add_Void_Action_1_String_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_remove_LinkReceived_Public_Virtual_Final_New_rem_Void_Action_1_String_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_PollInfoAfterPause_Public_Virtual_Final_New_Void_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_OnLinkReceived_Protected_Virtual_New_Void_String_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
