using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x0200010D RID: 269
	public class BsonRegex : BsonToken
	{
		// Token: 0x060015FB RID: 5627 RVA: 0x000768E8 File Offset: 0x00074AE8
		// Note: this type is marked as 'beforefieldinit'.
		static BsonRegex()
		{
			Il2CppClassPointerStore<BsonRegex>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Bson", "BsonRegex");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BsonRegex>.NativeClassPtr);
			BsonRegex.NativeFieldInfoPtr__Pattern_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonRegex>.NativeClassPtr, "<Pattern>k__BackingField");
			BsonRegex.NativeFieldInfoPtr__Options_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonRegex>.NativeClassPtr, "<Options>k__BackingField");
			BsonRegex.NativeMethodInfoPtr_get_Pattern_Public_get_BsonString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonRegex>.NativeClassPtr, 100667423);
			BsonRegex.NativeMethodInfoPtr_set_Pattern_Public_set_Void_BsonString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonRegex>.NativeClassPtr, 100667424);
			BsonRegex.NativeMethodInfoPtr_get_Options_Public_get_BsonString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonRegex>.NativeClassPtr, 100667425);
			BsonRegex.NativeMethodInfoPtr_set_Options_Public_set_Void_BsonString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonRegex>.NativeClassPtr, 100667426);
			BsonRegex.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonRegex>.NativeClassPtr, 100667427);
			BsonRegex.NativeMethodInfoPtr_get_Type_Public_Virtual_get_BsonType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonRegex>.NativeClassPtr, 100667428);
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x060015FC RID: 5628 RVA: 0x000769B8 File Offset: 0x00074BB8
		// (set) Token: 0x060015FD RID: 5629 RVA: 0x000769F8 File Offset: 0x00074BF8
		public unsafe BsonString Pattern
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonRegex.NativeMethodInfoPtr_get_Pattern_Public_get_BsonString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BsonString>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonRegex.NativeMethodInfoPtr_set_Pattern_Public_set_Void_BsonString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x060015FE RID: 5630 RVA: 0x00076A3C File Offset: 0x00074C3C
		// (set) Token: 0x060015FF RID: 5631 RVA: 0x00076A7C File Offset: 0x00074C7C
		public unsafe BsonString Options
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonRegex.NativeMethodInfoPtr_get_Options_Public_get_BsonString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BsonString>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonRegex.NativeMethodInfoPtr_set_Options_Public_set_Void_BsonString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x00076AC0 File Offset: 0x00074CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767135, XrefRangeEnd = 767147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BsonRegex(string pattern, string options)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BsonRegex>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonRegex.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001601 RID: 5633 RVA: 0x00076B20 File Offset: 0x00074D20
		public unsafe override BsonType Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BsonRegex.NativeMethodInfoPtr_get_Type_Public_Virtual_get_BsonType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x000089CC File Offset: 0x00006BCC
		public BsonRegex(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06001603 RID: 5635 RVA: 0x00076B68 File Offset: 0x00074D68
		// (set) Token: 0x06001604 RID: 5636 RVA: 0x000089D5 File Offset: 0x00006BD5
		public unsafe BsonString _Pattern_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonRegex.NativeFieldInfoPtr__Pattern_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BsonString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonRegex.NativeFieldInfoPtr__Pattern_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001605 RID: 5637 RVA: 0x00076B98 File Offset: 0x00074D98
		// (set) Token: 0x06001606 RID: 5638 RVA: 0x000089F4 File Offset: 0x00006BF4
		public unsafe BsonString _Options_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonRegex.NativeFieldInfoPtr__Options_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BsonString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonRegex.NativeFieldInfoPtr__Options_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011B1 RID: 4529
		private static readonly IntPtr NativeFieldInfoPtr__Pattern_k__BackingField;

		// Token: 0x040011B2 RID: 4530
		private static readonly IntPtr NativeFieldInfoPtr__Options_k__BackingField;

		// Token: 0x040011B3 RID: 4531
		private static readonly IntPtr NativeMethodInfoPtr_get_Pattern_Public_get_BsonString_0;

		// Token: 0x040011B4 RID: 4532
		private static readonly IntPtr NativeMethodInfoPtr_set_Pattern_Public_set_Void_BsonString_0;

		// Token: 0x040011B5 RID: 4533
		private static readonly IntPtr NativeMethodInfoPtr_get_Options_Public_get_BsonString_0;

		// Token: 0x040011B6 RID: 4534
		private static readonly IntPtr NativeMethodInfoPtr_set_Options_Public_set_Void_BsonString_0;

		// Token: 0x040011B7 RID: 4535
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x040011B8 RID: 4536
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_get_BsonType_0;
	}
}
