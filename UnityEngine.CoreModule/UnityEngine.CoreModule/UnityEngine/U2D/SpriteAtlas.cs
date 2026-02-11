using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.U2D
{
	// Token: 0x0200018A RID: 394
	public class SpriteAtlas : Object
	{
		// Token: 0x06001D70 RID: 7536 RVA: 0x00086AF4 File Offset: 0x00084CF4
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteAtlas()
		{
			Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.U2D", "SpriteAtlas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr);
			SpriteAtlas.NativeMethodInfoPtr_get_isVariant_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr, 100667407);
			SpriteAtlas.NativeMethodInfoPtr_get_tag_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr, 100667408);
			SpriteAtlas.NativeMethodInfoPtr_get_spriteCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr, 100667409);
			SpriteAtlas.NativeMethodInfoPtr_CanBindTo_Public_Boolean_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr, 100667410);
			SpriteAtlas.NativeMethodInfoPtr_GetSprite_Public_Sprite_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr, 100667411);
			SpriteAtlas.NativeMethodInfoPtr_GetSprites_Public_Int32_Il2CppReferenceArray_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr, 100667412);
			SpriteAtlas.NativeMethodInfoPtr_GetSprites_Public_Int32_Il2CppReferenceArray_1_Sprite_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr, 100667413);
			SpriteAtlas.NativeMethodInfoPtr_GetSpritesScripting_Private_Int32_Il2CppReferenceArray_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr, 100667414);
			SpriteAtlas.NativeMethodInfoPtr_GetSpritesWithNameScripting_Private_Int32_Il2CppReferenceArray_1_Sprite_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr, 100667415);
			SpriteAtlas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr, 100667416);
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06001D71 RID: 7537 RVA: 0x00086BEC File Offset: 0x00084DEC
		public unsafe bool isVariant
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677542, XrefRangeEnd = 677544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlas.NativeMethodInfoPtr_get_isVariant_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06001D72 RID: 7538 RVA: 0x00086C28 File Offset: 0x00084E28
		public unsafe string tag
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677544, XrefRangeEnd = 677546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlas.NativeMethodInfoPtr_get_tag_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06001D73 RID: 7539 RVA: 0x00086C60 File Offset: 0x00084E60
		public unsafe int spriteCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677546, XrefRangeEnd = 677548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlas.NativeMethodInfoPtr_get_spriteCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x00086C9C File Offset: 0x00084E9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 677550, RefRangeEnd = 677551, XrefRangeStart = 677548, XrefRangeEnd = 677550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanBindTo(Sprite sprite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlas.NativeMethodInfoPtr_CanBindTo_Public_Boolean_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x00086CEC File Offset: 0x00084EEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 677553, RefRangeEnd = 677555, XrefRangeStart = 677551, XrefRangeEnd = 677553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sprite GetSprite(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlas.NativeMethodInfoPtr_GetSprite_Public_Sprite_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x00086D3C File Offset: 0x00084F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677555, XrefRangeEnd = 677557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetSprites(Il2CppReferenceArray<Sprite> sprites)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprites);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlas.NativeMethodInfoPtr_GetSprites_Public_Int32_Il2CppReferenceArray_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D77 RID: 7543 RVA: 0x00086D8C File Offset: 0x00084F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677557, XrefRangeEnd = 677559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetSprites(Il2CppReferenceArray<Sprite> sprites, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprites);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlas.NativeMethodInfoPtr_GetSprites_Public_Int32_Il2CppReferenceArray_1_Sprite_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x00086DEC File Offset: 0x00084FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetSpritesScripting(Il2CppReferenceArray<Sprite> sprites)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprites);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlas.NativeMethodInfoPtr_GetSpritesScripting_Private_Int32_Il2CppReferenceArray_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x00086E3C File Offset: 0x0008503C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetSpritesWithNameScripting(Il2CppReferenceArray<Sprite> sprites, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprites);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlas.NativeMethodInfoPtr_GetSpritesWithNameScripting_Private_Int32_Il2CppReferenceArray_1_Sprite_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x00086E9C File Offset: 0x0008509C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 677559, XrefRangeEnd = 677563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpriteAtlas()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x0000B029 File Offset: 0x00009229
		public SpriteAtlas(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001A11 RID: 6673
		private static readonly IntPtr NativeMethodInfoPtr_get_isVariant_Public_get_Boolean_0;

		// Token: 0x04001A12 RID: 6674
		private static readonly IntPtr NativeMethodInfoPtr_get_tag_Public_get_String_0;

		// Token: 0x04001A13 RID: 6675
		private static readonly IntPtr NativeMethodInfoPtr_get_spriteCount_Public_get_Int32_0;

		// Token: 0x04001A14 RID: 6676
		private static readonly IntPtr NativeMethodInfoPtr_CanBindTo_Public_Boolean_Sprite_0;

		// Token: 0x04001A15 RID: 6677
		private static readonly IntPtr NativeMethodInfoPtr_GetSprite_Public_Sprite_String_0;

		// Token: 0x04001A16 RID: 6678
		private static readonly IntPtr NativeMethodInfoPtr_GetSprites_Public_Int32_Il2CppReferenceArray_1_Sprite_0;

		// Token: 0x04001A17 RID: 6679
		private static readonly IntPtr NativeMethodInfoPtr_GetSprites_Public_Int32_Il2CppReferenceArray_1_Sprite_String_0;

		// Token: 0x04001A18 RID: 6680
		private static readonly IntPtr NativeMethodInfoPtr_GetSpritesScripting_Private_Int32_Il2CppReferenceArray_1_Sprite_0;

		// Token: 0x04001A19 RID: 6681
		private static readonly IntPtr NativeMethodInfoPtr_GetSpritesWithNameScripting_Private_Int32_Il2CppReferenceArray_1_Sprite_String_0;

		// Token: 0x04001A1A RID: 6682
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
