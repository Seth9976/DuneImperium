using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.eventTriggers
{
	// Token: 0x020001A9 RID: 425
	public sealed class ArrowID : TypedID
	{
		// Token: 0x06001820 RID: 6176 RVA: 0x0007462C File Offset: 0x0007282C
		// Note: this type is marked as 'beforefieldinit'.
		static ArrowID()
		{
			Il2CppClassPointerStore<ArrowID>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.eventTriggers", "ArrowID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrowID>.NativeClassPtr);
			ArrowID.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrowID>.NativeClassPtr, 100667151);
			ArrowID.NativeMethodInfoPtr__ctor_Public_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrowID>.NativeClassPtr, 100667152);
			ArrowID.NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrowID>.NativeClassPtr, 100667153);
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x00074698 File Offset: 0x00072898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880235, XrefRangeEnd = 880239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrowID(string id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrowID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrowID.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x000746E4 File Offset: 0x000728E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880239, XrefRangeEnd = 880243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrowID(Guid id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrowID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrowID.NativeMethodInfoPtr__ctor_Public_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x0007472C File Offset: 0x0007292C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880243, XrefRangeEnd = 880250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypedID CreateID(string guid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrowID.NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypedID>(intPtr3) : null;
			}
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x0000A95C File Offset: 0x00008B5C
		public ArrowID(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001116 RID: 4374
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001117 RID: 4375
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_0;

		// Token: 0x04001118 RID: 4376
		private static readonly IntPtr NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0;
	}
}
