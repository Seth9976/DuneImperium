using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.utils.ids
{
	// Token: 0x02000023 RID: 35
	public sealed class WrappedID : TypedID
	{
		// Token: 0x06000166 RID: 358 RVA: 0x0000A0F4 File Offset: 0x000082F4
		// Note: this type is marked as 'beforefieldinit'.
		static WrappedID()
		{
			Il2CppClassPointerStore<WrappedID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Canis.utils.ids", "WrappedID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WrappedID>.NativeClassPtr);
			WrappedID.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WrappedID>.NativeClassPtr, 100663525);
			WrappedID.NativeMethodInfoPtr__ctor_Public_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WrappedID>.NativeClassPtr, 100663526);
			WrappedID.NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WrappedID>.NativeClassPtr, 100663527);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000A160 File Offset: 0x00008360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181141, XrefRangeEnd = 1181146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WrappedID(string id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WrappedID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WrappedID.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000A1AC File Offset: 0x000083AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1181150, RefRangeEnd = 1181151, XrefRangeStart = 1181146, XrefRangeEnd = 1181150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WrappedID(Guid id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WrappedID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WrappedID.NativeMethodInfoPtr__ctor_Public_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000A1F4 File Offset: 0x000083F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181151, XrefRangeEnd = 1181159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypedID CreateID(string guid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WrappedID.NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypedID>(intPtr3) : null;
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002629 File Offset: 0x00000829
		public WrappedID(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_0;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0;
	}
}
