using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.session
{
	// Token: 0x020000F6 RID: 246
	public sealed class SessionID : TypedID
	{
		// Token: 0x06000E7B RID: 3707 RVA: 0x0004D104 File Offset: 0x0004B304
		// Note: this type is marked as 'beforefieldinit'.
		static SessionID()
		{
			Il2CppClassPointerStore<SessionID>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.session", "SessionID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionID>.NativeClassPtr);
			SessionID.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionID>.NativeClassPtr, 100665392);
			SessionID.NativeMethodInfoPtr__ctor_Public_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionID>.NativeClassPtr, 100665393);
			SessionID.NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionID>.NativeClassPtr, 100665394);
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x0004D170 File Offset: 0x0004B370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867313, XrefRangeEnd = 867317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SessionID(string id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SessionID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionID.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x0004D1BC File Offset: 0x0004B3BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867317, XrefRangeEnd = 867321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SessionID(Guid id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SessionID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionID.NativeMethodInfoPtr__ctor_Public_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x0004D204 File Offset: 0x0004B404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867321, XrefRangeEnd = 867328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypedID CreateID(string guid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SessionID.NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypedID>(intPtr3) : null;
			}
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x00006EA2 File Offset: 0x000050A2
		public SessionID(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A68 RID: 2664
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000A69 RID: 2665
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_0;

		// Token: 0x04000A6A RID: 2666
		private static readonly IntPtr NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0;
	}
}
