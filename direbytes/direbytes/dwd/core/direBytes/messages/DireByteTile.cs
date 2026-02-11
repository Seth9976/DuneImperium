using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.direBytes.messages
{
	// Token: 0x02000019 RID: 25
	public class DireByteTile : Object
	{
		// Token: 0x06000117 RID: 279 RVA: 0x00006A70 File Offset: 0x00004C70
		// Note: this type is marked as 'beforefieldinit'.
		static DireByteTile()
		{
			Il2CppClassPointerStore<DireByteTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "dwd.core.direBytes.messages", "DireByteTile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireByteTile>.NativeClassPtr);
			DireByteTile.NativeFieldInfoPtr_TileID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTile>.NativeClassPtr, "TileID");
			DireByteTile.NativeFieldInfoPtr_Release = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTile>.NativeClassPtr, "Release");
			DireByteTile.NativeFieldInfoPtr_Properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTile>.NativeClassPtr, "Properties");
			DireByteTile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteTile>.NativeClassPtr, 100663430);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00006AF0 File Offset: 0x00004CF0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DireByteTile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireByteTile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteTile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000287E File Offset: 0x00000A7E
		public DireByteTile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00006B2C File Offset: 0x00004D2C
		// (set) Token: 0x0600011B RID: 283 RVA: 0x00002887 File Offset: 0x00000A87
		public unsafe string TileID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTile.NativeFieldInfoPtr_TileID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTile.NativeFieldInfoPtr_TileID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00006B54 File Offset: 0x00004D54
		// (set) Token: 0x0600011D RID: 285 RVA: 0x000028A6 File Offset: 0x00000AA6
		public unsafe string Release
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTile.NativeFieldInfoPtr_Release);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTile.NativeFieldInfoPtr_Release), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00006B7C File Offset: 0x00004D7C
		// (set) Token: 0x0600011F RID: 287 RVA: 0x000028C5 File Offset: 0x00000AC5
		public unsafe DireByteTileProperties Properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTile.NativeFieldInfoPtr_Properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DireByteTileProperties>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTile.NativeFieldInfoPtr_Properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeFieldInfoPtr_TileID;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeFieldInfoPtr_Release;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeFieldInfoPtr_Properties;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
