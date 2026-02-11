using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x0200010E RID: 270
	public class BsonProperty : Object
	{
		// Token: 0x06001607 RID: 5639 RVA: 0x00076BC8 File Offset: 0x00074DC8
		// Note: this type is marked as 'beforefieldinit'.
		static BsonProperty()
		{
			Il2CppClassPointerStore<BsonProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Bson", "BsonProperty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BsonProperty>.NativeClassPtr);
			BsonProperty.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonProperty>.NativeClassPtr, "<Name>k__BackingField");
			BsonProperty.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonProperty>.NativeClassPtr, "<Value>k__BackingField");
			BsonProperty.NativeMethodInfoPtr_get_Name_Public_get_BsonString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonProperty>.NativeClassPtr, 100667429);
			BsonProperty.NativeMethodInfoPtr_set_Name_Public_set_Void_BsonString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonProperty>.NativeClassPtr, 100667430);
			BsonProperty.NativeMethodInfoPtr_get_Value_Public_get_BsonToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonProperty>.NativeClassPtr, 100667431);
			BsonProperty.NativeMethodInfoPtr_set_Value_Public_set_Void_BsonToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonProperty>.NativeClassPtr, 100667432);
			BsonProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonProperty>.NativeClassPtr, 100667433);
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001608 RID: 5640 RVA: 0x00076C84 File Offset: 0x00074E84
		// (set) Token: 0x06001609 RID: 5641 RVA: 0x00076CC4 File Offset: 0x00074EC4
		public unsafe BsonString Name
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonProperty.NativeMethodInfoPtr_get_Name_Public_get_BsonString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BsonString>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonProperty.NativeMethodInfoPtr_set_Name_Public_set_Void_BsonString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x0600160A RID: 5642 RVA: 0x00076D08 File Offset: 0x00074F08
		// (set) Token: 0x0600160B RID: 5643 RVA: 0x00076D48 File Offset: 0x00074F48
		public unsafe BsonToken Value
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonProperty.NativeMethodInfoPtr_get_Value_Public_get_BsonToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BsonToken>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonProperty.NativeMethodInfoPtr_set_Value_Public_set_Void_BsonToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x00076D8C File Offset: 0x00074F8C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BsonProperty()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BsonProperty>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x00008A13 File Offset: 0x00006C13
		public BsonProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x0600160E RID: 5646 RVA: 0x00076DC8 File Offset: 0x00074FC8
		// (set) Token: 0x0600160F RID: 5647 RVA: 0x00008A1C File Offset: 0x00006C1C
		public unsafe BsonString _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonProperty.NativeFieldInfoPtr__Name_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BsonString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonProperty.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06001610 RID: 5648 RVA: 0x00076DF8 File Offset: 0x00074FF8
		// (set) Token: 0x06001611 RID: 5649 RVA: 0x00008A3B File Offset: 0x00006C3B
		public unsafe BsonToken _Value_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonProperty.NativeFieldInfoPtr__Value_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BsonToken>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonProperty.NativeFieldInfoPtr__Value_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011B9 RID: 4537
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x040011BA RID: 4538
		private static readonly IntPtr NativeFieldInfoPtr__Value_k__BackingField;

		// Token: 0x040011BB RID: 4539
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_BsonString_0;

		// Token: 0x040011BC RID: 4540
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_BsonString_0;

		// Token: 0x040011BD RID: 4541
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_BsonToken_0;

		// Token: 0x040011BE RID: 4542
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_BsonToken_0;

		// Token: 0x040011BF RID: 4543
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
