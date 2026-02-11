using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.utils.ids
{
	// Token: 0x02000018 RID: 24
	public sealed class ClientEventResponseID : TypedID
	{
		// Token: 0x06000107 RID: 263 RVA: 0x00008950 File Offset: 0x00006B50
		// Note: this type is marked as 'beforefieldinit'.
		static ClientEventResponseID()
		{
			Il2CppClassPointerStore<ClientEventResponseID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Canis.utils.ids", "ClientEventResponseID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientEventResponseID>.NativeClassPtr);
			ClientEventResponseID.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventResponseID>.NativeClassPtr, 100663463);
			ClientEventResponseID.NativeMethodInfoPtr__ctor_Public_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventResponseID>.NativeClassPtr, 100663464);
			ClientEventResponseID.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventResponseID>.NativeClassPtr, 100663465);
			ClientEventResponseID.NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEventResponseID>.NativeClassPtr, 100663466);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000089D0 File Offset: 0x00006BD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1179772, RefRangeEnd = 1179774, XrefRangeStart = 1179767, XrefRangeEnd = 1179772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientEventResponseID(string id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientEventResponseID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventResponseID.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00008A1C File Offset: 0x00006C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179774, XrefRangeEnd = 1179778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientEventResponseID(Guid id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientEventResponseID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventResponseID.NativeMethodInfoPtr__ctor_Public_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00008A64 File Offset: 0x00006C64
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 1179783, RefRangeEnd = 1179819, XrefRangeStart = 1179778, XrefRangeEnd = 1179783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientEventResponseID()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientEventResponseID>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventResponseID.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00008AA0 File Offset: 0x00006CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179819, XrefRangeEnd = 1179827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypedID CreateID(string guid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEventResponseID.NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypedID>(intPtr3) : null;
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000250E File Offset: 0x0000070E
		public ClientEventResponseID(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0;
	}
}
