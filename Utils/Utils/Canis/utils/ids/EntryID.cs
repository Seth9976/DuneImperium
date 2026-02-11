using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.utils.ids
{
	// Token: 0x0200001A RID: 26
	public class EntryID : TypedID
	{
		// Token: 0x06000115 RID: 277 RVA: 0x00008CB4 File Offset: 0x00006EB4
		// Note: this type is marked as 'beforefieldinit'.
		static EntryID()
		{
			Il2CppClassPointerStore<EntryID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Canis.utils.ids", "EntryID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntryID>.NativeClassPtr);
			EntryID.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntryID>.NativeClassPtr, "Empty");
			EntryID.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntryID>.NativeClassPtr, 100663472);
			EntryID.NativeMethodInfoPtr__ctor_Public_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntryID>.NativeClassPtr, 100663473);
			EntryID.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntryID>.NativeClassPtr, 100663474);
			EntryID.NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntryID>.NativeClassPtr, 100663475);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00008D48 File Offset: 0x00006F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179868, XrefRangeEnd = 1179873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntryID(string id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntryID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntryID.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00008D94 File Offset: 0x00006F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179873, XrefRangeEnd = 1179877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntryID(Guid id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntryID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntryID.NativeMethodInfoPtr__ctor_Public_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00008DDC File Offset: 0x00006FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179877, XrefRangeEnd = 1179882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntryID()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntryID>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntryID.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00008E18 File Offset: 0x00007018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179882, XrefRangeEnd = 1179890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypedID CreateID(string guid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntryID.NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypedID>(intPtr3) : null;
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002532 File Offset: 0x00000732
		public EntryID(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00008E5C File Offset: 0x0000705C
		// (set) Token: 0x0600011C RID: 284 RVA: 0x0000253B File Offset: 0x0000073B
		public unsafe static EntryID Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntryID.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntryID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntryID.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0;
	}
}
