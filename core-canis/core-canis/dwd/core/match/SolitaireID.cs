using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.match
{
	// Token: 0x02000130 RID: 304
	public sealed class SolitaireID : TypedID
	{
		// Token: 0x06001167 RID: 4455 RVA: 0x00059024 File Offset: 0x00057224
		// Note: this type is marked as 'beforefieldinit'.
		static SolitaireID()
		{
			Il2CppClassPointerStore<SolitaireID>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match", "SolitaireID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SolitaireID>.NativeClassPtr);
			SolitaireID.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SolitaireID>.NativeClassPtr, 100665844);
			SolitaireID.NativeMethodInfoPtr__ctor_Public_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SolitaireID>.NativeClassPtr, 100665845);
			SolitaireID.NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SolitaireID>.NativeClassPtr, 100665846);
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x00059090 File Offset: 0x00057290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870975, XrefRangeEnd = 870979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SolitaireID(string id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SolitaireID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SolitaireID.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x000590DC File Offset: 0x000572DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870979, XrefRangeEnd = 870983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SolitaireID(Guid id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SolitaireID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SolitaireID.NativeMethodInfoPtr__ctor_Public_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x00059124 File Offset: 0x00057324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 870983, XrefRangeEnd = 870990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypedID CreateID(string guid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SolitaireID.NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypedID>(intPtr3) : null;
			}
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x000080AD File Offset: 0x000062AD
		public SolitaireID(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C63 RID: 3171
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000C64 RID: 3172
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_0;

		// Token: 0x04000C65 RID: 3173
		private static readonly IntPtr NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0;
	}
}
