using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace ImaginationOverflow.UniversalDeepLinking.Providers
{
	// Token: 0x02000015 RID: 21
	public class EditorLinkProvider : Object
	{
		// Token: 0x060000FD RID: 253 RVA: 0x000060BC File Offset: 0x000042BC
		// Note: this type is marked as 'beforefieldinit'.
		static EditorLinkProvider()
		{
			Il2CppClassPointerStore<EditorLinkProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UniversalDeepLinking.dll", "ImaginationOverflow.UniversalDeepLinking.Providers", "EditorLinkProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EditorLinkProvider>.NativeClassPtr);
			EditorLinkProvider.NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorLinkProvider>.NativeClassPtr, "_instance");
			EditorLinkProvider.NativeFieldInfoPtr_WindowsProviderForEditorLauncher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorLinkProvider>.NativeClassPtr, "WindowsProviderForEditorLauncher");
			EditorLinkProvider.NativeFieldInfoPtr_LinkReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorLinkProvider>.NativeClassPtr, "LinkReceived");
			EditorLinkProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorLinkProvider>.NativeClassPtr, 100663467);
			EditorLinkProvider.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorLinkProvider>.NativeClassPtr, 100663468);
			EditorLinkProvider.NativeMethodInfoPtr_add_LinkReceived_Public_Virtual_Final_New_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorLinkProvider>.NativeClassPtr, 100663469);
			EditorLinkProvider.NativeMethodInfoPtr_remove_LinkReceived_Public_Virtual_Final_New_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorLinkProvider>.NativeClassPtr, 100663470);
			EditorLinkProvider.NativeMethodInfoPtr_PollInfoAfterPause_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorLinkProvider>.NativeClassPtr, 100663471);
			EditorLinkProvider.NativeMethodInfoPtr_SimulateLink_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorLinkProvider>.NativeClassPtr, 100663472);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000061A0 File Offset: 0x000043A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241214, XrefRangeEnd = 1241219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EditorLinkProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EditorLinkProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorLinkProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000061DC File Offset: 0x000043DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241219, XrefRangeEnd = 1241223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorLinkProvider.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00006218 File Offset: 0x00004418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241223, XrefRangeEnd = 1241228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_LinkReceived(Action<string> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorLinkProvider.NativeMethodInfoPtr_add_LinkReceived_Public_Virtual_Final_New_add_Void_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000625C File Offset: 0x0000445C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241228, XrefRangeEnd = 1241233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_LinkReceived(Action<string> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorLinkProvider.NativeMethodInfoPtr_remove_LinkReceived_Public_Virtual_Final_New_rem_Void_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000062A0 File Offset: 0x000044A0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PollInfoAfterPause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorLinkProvider.NativeMethodInfoPtr_PollInfoAfterPause_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000062D4 File Offset: 0x000044D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241233, XrefRangeEnd = 1241235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SimulateLink(string link)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(link);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorLinkProvider.NativeMethodInfoPtr_SimulateLink_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002590 File Offset: 0x00000790
		public EditorLinkProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000105 RID: 261 RVA: 0x0000630C File Offset: 0x0000450C
		// (set) Token: 0x06000106 RID: 262 RVA: 0x00002599 File Offset: 0x00000799
		public unsafe static EditorLinkProvider _instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EditorLinkProvider.NativeFieldInfoPtr__instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EditorLinkProvider>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EditorLinkProvider.NativeFieldInfoPtr__instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00006334 File Offset: 0x00004534
		// (set) Token: 0x06000108 RID: 264 RVA: 0x000025AB File Offset: 0x000007AB
		public unsafe static ILinkProvider WindowsProviderForEditorLauncher
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EditorLinkProvider.NativeFieldInfoPtr_WindowsProviderForEditorLauncher, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILinkProvider>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EditorLinkProvider.NativeFieldInfoPtr_WindowsProviderForEditorLauncher, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000109 RID: 265 RVA: 0x0000635C File Offset: 0x0000455C
		// (set) Token: 0x0600010A RID: 266 RVA: 0x000025BD File Offset: 0x000007BD
		public unsafe Action<string> LinkReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorLinkProvider.NativeFieldInfoPtr_LinkReceived);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorLinkProvider.NativeFieldInfoPtr_LinkReceived), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeFieldInfoPtr__instance;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeFieldInfoPtr_WindowsProviderForEditorLauncher;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeFieldInfoPtr_LinkReceived;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_add_LinkReceived_Public_Virtual_Final_New_add_Void_Action_1_String_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_remove_LinkReceived_Public_Virtual_Final_New_rem_Void_Action_1_String_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_PollInfoAfterPause_Public_Virtual_Final_New_Void_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_SimulateLink_Public_Static_Void_String_0;
	}
}
