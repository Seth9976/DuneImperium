using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.direBytes.messages
{
	// Token: 0x0200001A RID: 26
	public class DireByteTilePredicate : Object
	{
		// Token: 0x06000120 RID: 288 RVA: 0x00006BAC File Offset: 0x00004DAC
		// Note: this type is marked as 'beforefieldinit'.
		static DireByteTilePredicate()
		{
			Il2CppClassPointerStore<DireByteTilePredicate>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "dwd.core.direBytes.messages", "DireByteTilePredicate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireByteTilePredicate>.NativeClassPtr);
			DireByteTilePredicate.NativeFieldInfoPtr_Hint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTilePredicate>.NativeClassPtr, "Hint");
			DireByteTilePredicate.NativeFieldInfoPtr_ProductId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTilePredicate>.NativeClassPtr, "ProductId");
			DireByteTilePredicate.NativeFieldInfoPtr_ProductIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTilePredicate>.NativeClassPtr, "ProductIds");
			DireByteTilePredicate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteTilePredicate>.NativeClassPtr, 100663431);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00006C2C File Offset: 0x00004E2C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DireByteTilePredicate()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireByteTilePredicate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteTilePredicate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000028E4 File Offset: 0x00000AE4
		public DireByteTilePredicate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00006C68 File Offset: 0x00004E68
		// (set) Token: 0x06000124 RID: 292 RVA: 0x000028ED File Offset: 0x00000AED
		public unsafe string Hint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTilePredicate.NativeFieldInfoPtr_Hint);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTilePredicate.NativeFieldInfoPtr_Hint), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00006C90 File Offset: 0x00004E90
		// (set) Token: 0x06000126 RID: 294 RVA: 0x0000290C File Offset: 0x00000B0C
		public unsafe string ProductId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTilePredicate.NativeFieldInfoPtr_ProductId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTilePredicate.NativeFieldInfoPtr_ProductId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00006CB8 File Offset: 0x00004EB8
		// (set) Token: 0x06000128 RID: 296 RVA: 0x0000292B File Offset: 0x00000B2B
		public unsafe Il2CppStringArray ProductIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTilePredicate.NativeFieldInfoPtr_ProductIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTilePredicate.NativeFieldInfoPtr_ProductIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeFieldInfoPtr_Hint;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeFieldInfoPtr_ProductId;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeFieldInfoPtr_ProductIds;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
