using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.utils.ids
{
	// Token: 0x02000017 RID: 23
	[Serializable]
	public sealed class ArchetypeID : TypedID
	{
		// Token: 0x060000FF RID: 255 RVA: 0x00008780 File Offset: 0x00006980
		// Note: this type is marked as 'beforefieldinit'.
		static ArchetypeID()
		{
			Il2CppClassPointerStore<ArchetypeID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Canis.utils.ids", "ArchetypeID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchetypeID>.NativeClassPtr);
			ArchetypeID.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeID>.NativeClassPtr, "Empty");
			ArchetypeID.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeID>.NativeClassPtr, 100663458);
			ArchetypeID.NativeMethodInfoPtr__ctor_Public_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeID>.NativeClassPtr, 100663459);
			ArchetypeID.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeID>.NativeClassPtr, 100663460);
			ArchetypeID.NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeID>.NativeClassPtr, 100663461);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00008814 File Offset: 0x00006A14
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1179722, RefRangeEnd = 1179736, XrefRangeStart = 1179717, XrefRangeEnd = 1179722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArchetypeID(string id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchetypeID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeID.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00008860 File Offset: 0x00006A60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1179740, RefRangeEnd = 1179742, XrefRangeStart = 1179736, XrefRangeEnd = 1179740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArchetypeID(Guid id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchetypeID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeID.NativeMethodInfoPtr__ctor_Public_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000088A8 File Offset: 0x00006AA8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1179747, RefRangeEnd = 1179759, XrefRangeStart = 1179742, XrefRangeEnd = 1179747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArchetypeID()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchetypeID>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeID.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000088E4 File Offset: 0x00006AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179759, XrefRangeEnd = 1179767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypedID CreateID(string guid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeID.NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypedID>(intPtr3) : null;
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000024F3 File Offset: 0x000006F3
		public ArchetypeID(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00008928 File Offset: 0x00006B28
		// (set) Token: 0x06000106 RID: 262 RVA: 0x000024FC File Offset: 0x000006FC
		public unsafe static ArchetypeID Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ArchetypeID.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ArchetypeID.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0;
	}
}
