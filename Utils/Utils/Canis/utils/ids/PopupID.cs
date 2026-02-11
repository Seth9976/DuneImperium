using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.utils.ids
{
	// Token: 0x0200001E RID: 30
	public sealed class PopupID : TypedID
	{
		// Token: 0x06000132 RID: 306 RVA: 0x00009368 File Offset: 0x00007568
		// Note: this type is marked as 'beforefieldinit'.
		static PopupID()
		{
			Il2CppClassPointerStore<PopupID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Canis.utils.ids", "PopupID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PopupID>.NativeClassPtr);
			PopupID.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupID>.NativeClassPtr, 100663490);
			PopupID.NativeMethodInfoPtr__ctor_Public_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupID>.NativeClassPtr, 100663491);
			PopupID.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupID>.NativeClassPtr, 100663492);
			PopupID.NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupID>.NativeClassPtr, 100663493);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000093E8 File Offset: 0x000075E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179958, XrefRangeEnd = 1179963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PopupID(string id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PopupID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupID.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00009434 File Offset: 0x00007634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179963, XrefRangeEnd = 1179967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PopupID(Guid id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PopupID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupID.NativeMethodInfoPtr__ctor_Public_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000947C File Offset: 0x0000767C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1179972, RefRangeEnd = 1179973, XrefRangeStart = 1179967, XrefRangeEnd = 1179972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PopupID()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PopupID>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupID.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000094B8 File Offset: 0x000076B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179973, XrefRangeEnd = 1179981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypedID CreateID(string guid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupID.NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypedID>(intPtr3) : null;
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000258C File Offset: 0x0000078C
		public PopupID(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0;
	}
}
