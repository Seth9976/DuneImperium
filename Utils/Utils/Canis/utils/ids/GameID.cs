using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.utils.ids
{
	// Token: 0x0200001C RID: 28
	[Serializable]
	public sealed class GameID : TypedID
	{
		// Token: 0x06000125 RID: 293 RVA: 0x00009054 File Offset: 0x00007254
		// Note: this type is marked as 'beforefieldinit'.
		static GameID()
		{
			Il2CppClassPointerStore<GameID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Canis.utils.ids", "GameID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameID>.NativeClassPtr);
			GameID.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameID>.NativeClassPtr, "Empty");
			GameID.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameID>.NativeClassPtr, 100663482);
			GameID.NativeMethodInfoPtr__ctor_Public_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameID>.NativeClassPtr, 100663483);
			GameID.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameID>.NativeClassPtr, 100663484);
			GameID.NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameID>.NativeClassPtr, 100663485);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000090E8 File Offset: 0x000072E8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1179917, RefRangeEnd = 1179922, XrefRangeStart = 1179912, XrefRangeEnd = 1179917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameID(string id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameID.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00009134 File Offset: 0x00007334
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1179926, RefRangeEnd = 1179928, XrefRangeStart = 1179922, XrefRangeEnd = 1179926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameID(Guid id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameID.NativeMethodInfoPtr__ctor_Public_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000917C File Offset: 0x0000737C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179928, XrefRangeEnd = 1179933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameID()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameID>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameID.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000091B8 File Offset: 0x000073B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179933, XrefRangeEnd = 1179941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypedID CreateID(string guid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameID.NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypedID>(intPtr3) : null;
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002568 File Offset: 0x00000768
		public GameID(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600012B RID: 299 RVA: 0x000091FC File Offset: 0x000073FC
		// (set) Token: 0x0600012C RID: 300 RVA: 0x00002571 File Offset: 0x00000771
		public unsafe static GameID Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GameID.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameID.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_0;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0;
	}
}
