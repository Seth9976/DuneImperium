using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000244 RID: 580
	public class DSASignatureFormatter : AsymmetricSignatureFormatter
	{
		// Token: 0x060025F2 RID: 9714 RVA: 0x000D0DA8 File Offset: 0x000CEFA8
		// Note: this type is marked as 'beforefieldinit'.
		static DSASignatureFormatter()
		{
			Il2CppClassPointerStore<DSASignatureFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "DSASignatureFormatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DSASignatureFormatter>.NativeClassPtr);
			DSASignatureFormatter.NativeFieldInfoPtr__oid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSASignatureFormatter>.NativeClassPtr, "_oid");
			DSASignatureFormatter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSASignatureFormatter>.NativeClassPtr, 100669633);
		}

		// Token: 0x060025F3 RID: 9715 RVA: 0x000D0E00 File Offset: 0x000CF000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372037, XrefRangeEnd = 1372045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DSASignatureFormatter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DSASignatureFormatter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSASignatureFormatter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025F4 RID: 9716 RVA: 0x0000C4E0 File Offset: 0x0000A6E0
		public DSASignatureFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x060025F5 RID: 9717 RVA: 0x000D0E3C File Offset: 0x000CF03C
		// (set) Token: 0x060025F6 RID: 9718 RVA: 0x0000C4E9 File Offset: 0x0000A6E9
		public unsafe string _oid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSASignatureFormatter.NativeFieldInfoPtr__oid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSASignatureFormatter.NativeFieldInfoPtr__oid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040020F4 RID: 8436
		private static readonly IntPtr NativeFieldInfoPtr__oid;

		// Token: 0x040020F5 RID: 8437
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
