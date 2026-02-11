using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.IO
{
	// Token: 0x0200051A RID: 1306
	[StructLayout(2)]
	public struct DisableMediaInsertionPrompt
	{
		// Token: 0x06004FBF RID: 20415 RVA: 0x0017308C File Offset: 0x0017128C
		// Note: this type is marked as 'beforefieldinit'.
		static DisableMediaInsertionPrompt()
		{
			Il2CppClassPointerStore<DisableMediaInsertionPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "DisableMediaInsertionPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisableMediaInsertionPrompt>.NativeClassPtr);
			DisableMediaInsertionPrompt.NativeFieldInfoPtr__disableSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableMediaInsertionPrompt>.NativeClassPtr, "_disableSuccess");
			DisableMediaInsertionPrompt.NativeFieldInfoPtr__oldMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableMediaInsertionPrompt>.NativeClassPtr, "_oldMode");
			DisableMediaInsertionPrompt.NativeFieldInfoPtr_useUWPFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableMediaInsertionPrompt>.NativeClassPtr, "useUWPFallback");
			DisableMediaInsertionPrompt.NativeMethodInfoPtr_Create_Public_Static_DisableMediaInsertionPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableMediaInsertionPrompt>.NativeClassPtr, 100675328);
			DisableMediaInsertionPrompt.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableMediaInsertionPrompt>.NativeClassPtr, 100675329);
		}

		// Token: 0x06004FC0 RID: 20416 RVA: 0x00173120 File Offset: 0x00171320
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1426812, RefRangeEnd = 1426813, XrefRangeStart = 1426807, XrefRangeEnd = 1426812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DisableMediaInsertionPrompt Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisableMediaInsertionPrompt.NativeMethodInfoPtr_Create_Public_Static_DisableMediaInsertionPrompt_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004FC1 RID: 20417 RVA: 0x00173150 File Offset: 0x00171350
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1426814, RefRangeEnd = 1426816, XrefRangeStart = 1426813, XrefRangeEnd = 1426814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisableMediaInsertionPrompt.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FC2 RID: 20418 RVA: 0x0001C9D1 File Offset: 0x0001ABD1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DisableMediaInsertionPrompt>.NativeClassPtr, ref this));
		}

		// Token: 0x17001462 RID: 5218
		// (get) Token: 0x06004FC3 RID: 20419 RVA: 0x00173178 File Offset: 0x00171378
		// (set) Token: 0x06004FC4 RID: 20420 RVA: 0x0001C9E3 File Offset: 0x0001ABE3
		public unsafe static bool useUWPFallback
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DisableMediaInsertionPrompt.NativeFieldInfoPtr_useUWPFallback, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DisableMediaInsertionPrompt.NativeFieldInfoPtr_useUWPFallback, (void*)(&value));
			}
		}

		// Token: 0x040040F8 RID: 16632
		private static readonly IntPtr NativeFieldInfoPtr__disableSuccess;

		// Token: 0x040040F9 RID: 16633
		private static readonly IntPtr NativeFieldInfoPtr__oldMode;

		// Token: 0x040040FA RID: 16634
		private static readonly IntPtr NativeFieldInfoPtr_useUWPFallback;

		// Token: 0x040040FB RID: 16635
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_DisableMediaInsertionPrompt_0;

		// Token: 0x040040FC RID: 16636
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040040FD RID: 16637
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool _disableSuccess;

		// Token: 0x040040FE RID: 16638
		[FieldOffset(4)]
		public uint _oldMode;
	}
}
