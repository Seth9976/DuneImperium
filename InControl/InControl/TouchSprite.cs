using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200005A RID: 90
	[Serializable]
	public class TouchSprite : global::Il2CppSystem.Object
	{
		// Token: 0x060008D5 RID: 2261 RVA: 0x00026CF0 File Offset: 0x00024EF0
		// Note: this type is marked as 'beforefieldinit'.
		static TouchSprite()
		{
			Il2CppClassPointerStore<TouchSprite>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "TouchSprite");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr);
			TouchSprite.NativeFieldInfoPtr_idleSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, "idleSprite");
			TouchSprite.NativeFieldInfoPtr_busySprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, "busySprite");
			TouchSprite.NativeFieldInfoPtr_idleColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, "idleColor");
			TouchSprite.NativeFieldInfoPtr_busyColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, "busyColor");
			TouchSprite.NativeFieldInfoPtr_shape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, "shape");
			TouchSprite.NativeFieldInfoPtr_sizeUnitType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, "sizeUnitType");
			TouchSprite.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, "size");
			TouchSprite.NativeFieldInfoPtr_lockAspectRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, "lockAspectRatio");
			TouchSprite.NativeFieldInfoPtr_worldSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, "worldSize");
			TouchSprite.NativeFieldInfoPtr_spriteGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, "spriteGameObject");
			TouchSprite.NativeFieldInfoPtr_spriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, "spriteRenderer");
			TouchSprite.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, "state");
			TouchSprite.NativeFieldInfoPtr__Dirty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, "<Dirty>k__BackingField");
			TouchSprite.NativeFieldInfoPtr__Ready_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, "<Ready>k__BackingField");
			TouchSprite.NativeFieldInfoPtr_spriteRendererShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, "spriteRendererShader");
			TouchSprite.NativeFieldInfoPtr_spriteRendererMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, "spriteRendererMaterial");
			TouchSprite.NativeFieldInfoPtr_spriteRendererPixelSnapId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, "spriteRendererPixelSnapId");
			TouchSprite.NativeMethodInfoPtr_get_Dirty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664434);
			TouchSprite.NativeMethodInfoPtr_set_Dirty_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664435);
			TouchSprite.NativeMethodInfoPtr_get_Ready_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664436);
			TouchSprite.NativeMethodInfoPtr_set_Ready_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664437);
			TouchSprite.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664438);
			TouchSprite.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664439);
			TouchSprite.NativeMethodInfoPtr_Create_Public_Void_String_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664440);
			TouchSprite.NativeMethodInfoPtr_Delete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664441);
			TouchSprite.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664442);
			TouchSprite.NativeMethodInfoPtr_Update_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664443);
			TouchSprite.NativeMethodInfoPtr_CreateSpriteGameObject_Private_GameObject_String_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664444);
			TouchSprite.NativeMethodInfoPtr_CreateSpriteRenderer_Private_SpriteRenderer_GameObject_Sprite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664445);
			TouchSprite.NativeMethodInfoPtr_ScaleSpriteInPixels_Private_Void_GameObject_SpriteRenderer_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664446);
			TouchSprite.NativeMethodInfoPtr_ScaleSpriteInPercent_Private_Void_GameObject_SpriteRenderer_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664447);
			TouchSprite.NativeMethodInfoPtr_Contains_Public_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664448);
			TouchSprite.NativeMethodInfoPtr_Contains_Public_Boolean_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664449);
			TouchSprite.NativeMethodInfoPtr_DrawGizmos_Public_Void_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664450);
			TouchSprite.NativeMethodInfoPtr_get_State_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664451);
			TouchSprite.NativeMethodInfoPtr_set_State_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664452);
			TouchSprite.NativeMethodInfoPtr_get_BusySprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664453);
			TouchSprite.NativeMethodInfoPtr_set_BusySprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664454);
			TouchSprite.NativeMethodInfoPtr_get_IdleSprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664455);
			TouchSprite.NativeMethodInfoPtr_set_IdleSprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664456);
			TouchSprite.NativeMethodInfoPtr_set_Sprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664457);
			TouchSprite.NativeMethodInfoPtr_get_BusyColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664458);
			TouchSprite.NativeMethodInfoPtr_set_BusyColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664459);
			TouchSprite.NativeMethodInfoPtr_get_IdleColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664460);
			TouchSprite.NativeMethodInfoPtr_set_IdleColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664461);
			TouchSprite.NativeMethodInfoPtr_get_Shape_Public_get_TouchSpriteShape_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664462);
			TouchSprite.NativeMethodInfoPtr_set_Shape_Public_set_Void_TouchSpriteShape_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664463);
			TouchSprite.NativeMethodInfoPtr_get_SizeUnitType_Public_get_TouchUnitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664464);
			TouchSprite.NativeMethodInfoPtr_set_SizeUnitType_Public_set_Void_TouchUnitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664465);
			TouchSprite.NativeMethodInfoPtr_get_Size_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664466);
			TouchSprite.NativeMethodInfoPtr_set_Size_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664467);
			TouchSprite.NativeMethodInfoPtr_get_WorldSize_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664468);
			TouchSprite.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664469);
			TouchSprite.NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr, 100664470);
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x00027158 File Offset: 0x00025358
		// (set) Token: 0x060008D7 RID: 2263 RVA: 0x00027194 File Offset: 0x00025394
		public unsafe bool Dirty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_get_Dirty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_set_Dirty_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x000271D4 File Offset: 0x000253D4
		// (set) Token: 0x060008D9 RID: 2265 RVA: 0x00027210 File Offset: 0x00025410
		public unsafe bool Ready
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_get_Ready_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_set_Ready_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00027250 File Offset: 0x00025450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786058, XrefRangeEnd = 786059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchSprite()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x0002728C File Offset: 0x0002548C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 786062, RefRangeEnd = 786065, XrefRangeStart = 786059, XrefRangeEnd = 786062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchSprite(float size)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchSprite>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x000272D4 File Offset: 0x000254D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 786119, RefRangeEnd = 786122, XrefRangeStart = 786065, XrefRangeEnd = 786119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Create(string gameObjectName, Transform parentTransform, int sortingOrder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(gameObjectName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentTransform);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sortingOrder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_Create_Public_Void_String_Transform_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00027338 File Offset: 0x00025538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786122, XrefRangeEnd = 786126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Delete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_Delete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x0002736C File Offset: 0x0002556C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786126, XrefRangeEnd = 786127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x000273A0 File Offset: 0x000255A0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 786159, RefRangeEnd = 786166, XrefRangeStart = 786127, XrefRangeEnd = 786159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update(bool forceUpdate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref forceUpdate;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_Update_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x000273E0 File Offset: 0x000255E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786166, XrefRangeEnd = 786183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject CreateSpriteGameObject(string name, Transform parentTransform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentTransform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_CreateSpriteGameObject_Private_GameObject_String_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00027444 File Offset: 0x00025644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786183, XrefRangeEnd = 786217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpriteRenderer CreateSpriteRenderer(GameObject spriteGameObject, Sprite sprite, int sortingOrder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteGameObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sortingOrder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_CreateSpriteRenderer_Private_SpriteRenderer_GameObject_Sprite_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr3) : null;
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x000274B4 File Offset: 0x000256B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 786239, RefRangeEnd = 786240, XrefRangeStart = 786217, XrefRangeEnd = 786239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScaleSpriteInPixels(GameObject spriteGameObject, SpriteRenderer spriteRenderer, Vector2 size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteGameObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spriteRenderer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_ScaleSpriteInPixels_Private_Void_GameObject_SpriteRenderer_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00027518 File Offset: 0x00025718
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 786269, RefRangeEnd = 786270, XrefRangeStart = 786240, XrefRangeEnd = 786269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScaleSpriteInPercent(GameObject spriteGameObject, SpriteRenderer spriteRenderer, Vector2 size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteGameObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spriteRenderer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_ScaleSpriteInPercent_Private_Void_GameObject_SpriteRenderer_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x0002757C File Offset: 0x0002577C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 786277, RefRangeEnd = 786282, XrefRangeStart = 786270, XrefRangeEnd = 786277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(Vector2 testWorldPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref testWorldPoint;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_Contains_Public_Boolean_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x000275C8 File Offset: 0x000257C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786282, XrefRangeEnd = 786285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(Touch touch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(touch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_Contains_Public_Boolean_Touch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00027618 File Offset: 0x00025818
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 786292, RefRangeEnd = 786295, XrefRangeStart = 786285, XrefRangeEnd = 786292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawGizmos(Vector3 position, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_DrawGizmos_Public_Void_Vector3_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x060008E7 RID: 2279 RVA: 0x00027664 File Offset: 0x00025864
		// (set) Token: 0x060008E8 RID: 2280 RVA: 0x000276A0 File Offset: 0x000258A0
		public unsafe bool State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_get_State_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_set_State_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x060008E9 RID: 2281 RVA: 0x000276E0 File Offset: 0x000258E0
		// (set) Token: 0x060008EA RID: 2282 RVA: 0x00027720 File Offset: 0x00025920
		public unsafe Sprite BusySprite
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_get_BusySprite_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786295, XrefRangeEnd = 786300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_set_BusySprite_Public_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x060008EB RID: 2283 RVA: 0x00027764 File Offset: 0x00025964
		// (set) Token: 0x060008EC RID: 2284 RVA: 0x000277A4 File Offset: 0x000259A4
		public unsafe Sprite IdleSprite
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_get_IdleSprite_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786300, XrefRangeEnd = 786305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_set_IdleSprite_Public_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000361 RID: 865
		// (set) Token: 0x060008ED RID: 2285 RVA: 0x000277E8 File Offset: 0x000259E8
		public unsafe Sprite Sprite
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786305, XrefRangeEnd = 786314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_set_Sprite_Public_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x0002782C File Offset: 0x00025A2C
		// (set) Token: 0x060008EF RID: 2287 RVA: 0x00027868 File Offset: 0x00025A68
		public unsafe Color BusyColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_get_BusyColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_set_BusyColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x000278A8 File Offset: 0x00025AA8
		// (set) Token: 0x060008F1 RID: 2289 RVA: 0x000278E4 File Offset: 0x00025AE4
		public unsafe Color IdleColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_get_IdleColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_set_IdleColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x00027924 File Offset: 0x00025B24
		// (set) Token: 0x060008F3 RID: 2291 RVA: 0x00027960 File Offset: 0x00025B60
		public unsafe TouchSpriteShape Shape
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_get_Shape_Public_get_TouchSpriteShape_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_set_Shape_Public_set_Void_TouchSpriteShape_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x000279A0 File Offset: 0x00025BA0
		// (set) Token: 0x060008F5 RID: 2293 RVA: 0x000279DC File Offset: 0x00025BDC
		public unsafe TouchUnitType SizeUnitType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_get_SizeUnitType_Public_get_TouchUnitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_set_SizeUnitType_Public_set_Void_TouchUnitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x00027A1C File Offset: 0x00025C1C
		// (set) Token: 0x060008F7 RID: 2295 RVA: 0x00027A58 File Offset: 0x00025C58
		public unsafe Vector2 Size
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_get_Size_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_set_Size_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x00027A98 File Offset: 0x00025C98
		public unsafe Vector2 WorldSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_get_WorldSize_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x00027AD4 File Offset: 0x00025CD4
		// (set) Token: 0x060008FA RID: 2298 RVA: 0x00027B10 File Offset: 0x00025D10
		public unsafe Vector3 Position
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 786323, RefRangeEnd = 786345, XrefRangeStart = 786314, XrefRangeEnd = 786323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786345, XrefRangeEnd = 786351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchSprite.NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x000058A9 File Offset: 0x00003AA9
		public TouchSprite(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x00027B50 File Offset: 0x00025D50
		// (set) Token: 0x060008FD RID: 2301 RVA: 0x000058B2 File Offset: 0x00003AB2
		public unsafe Sprite idleSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSprite.NativeFieldInfoPtr_idleSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSprite.NativeFieldInfoPtr_idleSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x00027B80 File Offset: 0x00025D80
		// (set) Token: 0x060008FF RID: 2303 RVA: 0x000058D1 File Offset: 0x00003AD1
		public unsafe Sprite busySprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSprite.NativeFieldInfoPtr_busySprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSprite.NativeFieldInfoPtr_busySprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000900 RID: 2304 RVA: 0x00027BB0 File Offset: 0x00025DB0
		// (set) Token: 0x06000901 RID: 2305 RVA: 0x000058F0 File Offset: 0x00003AF0
		public unsafe Color idleColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSprite.NativeFieldInfoPtr_idleColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSprite.NativeFieldInfoPtr_idleColor)) = value;
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x00027BD8 File Offset: 0x00025DD8
		// (set) Token: 0x06000903 RID: 2307 RVA: 0x0000590B File Offset: 0x00003B0B
		public unsafe Color busyColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSprite.NativeFieldInfoPtr_busyColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSprite.NativeFieldInfoPtr_busyColor)) = value;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000904 RID: 2308 RVA: 0x00027C00 File Offset: 0x00025E00
		// (set) Token: 0x06000905 RID: 2309 RVA: 0x00005926 File Offset: 0x00003B26
		public unsafe TouchSpriteShape shape
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSprite.NativeFieldInfoPtr_shape);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSprite.NativeFieldInfoPtr_shape)) = value;
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x00027C28 File Offset: 0x00025E28
		// (set) Token: 0x06000907 RID: 2311 RVA: 0x00005941 File Offset: 0x00003B41
		public unsafe TouchUnitType sizeUnitType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSprite.NativeFieldInfoPtr_sizeUnitType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSprite.NativeFieldInfoPtr_sizeUnitType)) = value;
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x00027C50 File Offset: 0x00025E50
		// (set) Token: 0x06000909 RID: 2313 RVA: 0x0000595C File Offset: 0x00003B5C
		public unsafe Vector2 size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSprite.NativeFieldInfoPtr_size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSprite.NativeFieldInfoPtr_size)) = value;
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x00027C78 File Offset: 0x00025E78
		// (set) Token: 0x0600090B RID: 2315 RVA: 0x00005977 File Offset: 0x00003B77
		public unsafe bool lockAspectRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSprite.NativeFieldInfoPtr_lockAspectRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSprite.NativeFieldInfoPtr_lockAspectRatio)) = value;
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x00027CA0 File Offset: 0x00025EA0
		// (set) Token: 0x0600090D RID: 2317 RVA: 0x00005992 File Offset: 0x00003B92
		public unsafe Vector2 worldSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSprite.NativeFieldInfoPtr_worldSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSprite.NativeFieldInfoPtr_worldSize)) = value;
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x00027CC8 File Offset: 0x00025EC8
		// (set) Token: 0x0600090F RID: 2319 RVA: 0x000059AD File Offset: 0x00003BAD
		public unsafe GameObject spriteGameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSprite.NativeFieldInfoPtr_spriteGameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSprite.NativeFieldInfoPtr_spriteGameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x00027CF8 File Offset: 0x00025EF8
		// (set) Token: 0x06000911 RID: 2321 RVA: 0x000059CC File Offset: 0x00003BCC
		public unsafe SpriteRenderer spriteRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSprite.NativeFieldInfoPtr_spriteRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSprite.NativeFieldInfoPtr_spriteRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000912 RID: 2322 RVA: 0x00027D28 File Offset: 0x00025F28
		// (set) Token: 0x06000913 RID: 2323 RVA: 0x000059EB File Offset: 0x00003BEB
		public unsafe bool state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSprite.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSprite.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000914 RID: 2324 RVA: 0x00027D50 File Offset: 0x00025F50
		// (set) Token: 0x06000915 RID: 2325 RVA: 0x00005A06 File Offset: 0x00003C06
		public unsafe bool _Dirty_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSprite.NativeFieldInfoPtr__Dirty_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSprite.NativeFieldInfoPtr__Dirty_k__BackingField)) = value;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x00027D78 File Offset: 0x00025F78
		// (set) Token: 0x06000917 RID: 2327 RVA: 0x00005A21 File Offset: 0x00003C21
		public unsafe bool _Ready_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSprite.NativeFieldInfoPtr__Ready_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchSprite.NativeFieldInfoPtr__Ready_k__BackingField)) = value;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000918 RID: 2328 RVA: 0x00027DA0 File Offset: 0x00025FA0
		// (set) Token: 0x06000919 RID: 2329 RVA: 0x00005A3C File Offset: 0x00003C3C
		public unsafe static Shader spriteRendererShader
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TouchSprite.NativeFieldInfoPtr_spriteRendererShader, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TouchSprite.NativeFieldInfoPtr_spriteRendererShader, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x00027DC8 File Offset: 0x00025FC8
		// (set) Token: 0x0600091B RID: 2331 RVA: 0x00005A4E File Offset: 0x00003C4E
		public unsafe static Material spriteRendererMaterial
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TouchSprite.NativeFieldInfoPtr_spriteRendererMaterial, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TouchSprite.NativeFieldInfoPtr_spriteRendererMaterial, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x00027DF0 File Offset: 0x00025FF0
		// (set) Token: 0x0600091D RID: 2333 RVA: 0x00005A60 File Offset: 0x00003C60
		public unsafe static int spriteRendererPixelSnapId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TouchSprite.NativeFieldInfoPtr_spriteRendererPixelSnapId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TouchSprite.NativeFieldInfoPtr_spriteRendererPixelSnapId, (void*)(&value));
			}
		}

		// Token: 0x04000850 RID: 2128
		private static readonly IntPtr NativeFieldInfoPtr_idleSprite;

		// Token: 0x04000851 RID: 2129
		private static readonly IntPtr NativeFieldInfoPtr_busySprite;

		// Token: 0x04000852 RID: 2130
		private static readonly IntPtr NativeFieldInfoPtr_idleColor;

		// Token: 0x04000853 RID: 2131
		private static readonly IntPtr NativeFieldInfoPtr_busyColor;

		// Token: 0x04000854 RID: 2132
		private static readonly IntPtr NativeFieldInfoPtr_shape;

		// Token: 0x04000855 RID: 2133
		private static readonly IntPtr NativeFieldInfoPtr_sizeUnitType;

		// Token: 0x04000856 RID: 2134
		private static readonly IntPtr NativeFieldInfoPtr_size;

		// Token: 0x04000857 RID: 2135
		private static readonly IntPtr NativeFieldInfoPtr_lockAspectRatio;

		// Token: 0x04000858 RID: 2136
		private static readonly IntPtr NativeFieldInfoPtr_worldSize;

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeFieldInfoPtr_spriteGameObject;

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeFieldInfoPtr_spriteRenderer;

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x0400085C RID: 2140
		private static readonly IntPtr NativeFieldInfoPtr__Dirty_k__BackingField;

		// Token: 0x0400085D RID: 2141
		private static readonly IntPtr NativeFieldInfoPtr__Ready_k__BackingField;

		// Token: 0x0400085E RID: 2142
		private static readonly IntPtr NativeFieldInfoPtr_spriteRendererShader;

		// Token: 0x0400085F RID: 2143
		private static readonly IntPtr NativeFieldInfoPtr_spriteRendererMaterial;

		// Token: 0x04000860 RID: 2144
		private static readonly IntPtr NativeFieldInfoPtr_spriteRendererPixelSnapId;

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeMethodInfoPtr_get_Dirty_Public_get_Boolean_0;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeMethodInfoPtr_set_Dirty_Public_set_Void_Boolean_0;

		// Token: 0x04000863 RID: 2147
		private static readonly IntPtr NativeMethodInfoPtr_get_Ready_Public_get_Boolean_0;

		// Token: 0x04000864 RID: 2148
		private static readonly IntPtr NativeMethodInfoPtr_set_Ready_Public_set_Void_Boolean_0;

		// Token: 0x04000865 RID: 2149
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000866 RID: 2150
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04000867 RID: 2151
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Void_String_Transform_Int32_0;

		// Token: 0x04000868 RID: 2152
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Void_0;

		// Token: 0x04000869 RID: 2153
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x0400086A RID: 2154
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_Boolean_0;

		// Token: 0x0400086B RID: 2155
		private static readonly IntPtr NativeMethodInfoPtr_CreateSpriteGameObject_Private_GameObject_String_Transform_0;

		// Token: 0x0400086C RID: 2156
		private static readonly IntPtr NativeMethodInfoPtr_CreateSpriteRenderer_Private_SpriteRenderer_GameObject_Sprite_Int32_0;

		// Token: 0x0400086D RID: 2157
		private static readonly IntPtr NativeMethodInfoPtr_ScaleSpriteInPixels_Private_Void_GameObject_SpriteRenderer_Vector2_0;

		// Token: 0x0400086E RID: 2158
		private static readonly IntPtr NativeMethodInfoPtr_ScaleSpriteInPercent_Private_Void_GameObject_SpriteRenderer_Vector2_0;

		// Token: 0x0400086F RID: 2159
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Vector2_0;

		// Token: 0x04000870 RID: 2160
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Touch_0;

		// Token: 0x04000871 RID: 2161
		private static readonly IntPtr NativeMethodInfoPtr_DrawGizmos_Public_Void_Vector3_Color_0;

		// Token: 0x04000872 RID: 2162
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_Boolean_0;

		// Token: 0x04000873 RID: 2163
		private static readonly IntPtr NativeMethodInfoPtr_set_State_Public_set_Void_Boolean_0;

		// Token: 0x04000874 RID: 2164
		private static readonly IntPtr NativeMethodInfoPtr_get_BusySprite_Public_get_Sprite_0;

		// Token: 0x04000875 RID: 2165
		private static readonly IntPtr NativeMethodInfoPtr_set_BusySprite_Public_set_Void_Sprite_0;

		// Token: 0x04000876 RID: 2166
		private static readonly IntPtr NativeMethodInfoPtr_get_IdleSprite_Public_get_Sprite_0;

		// Token: 0x04000877 RID: 2167
		private static readonly IntPtr NativeMethodInfoPtr_set_IdleSprite_Public_set_Void_Sprite_0;

		// Token: 0x04000878 RID: 2168
		private static readonly IntPtr NativeMethodInfoPtr_set_Sprite_Public_set_Void_Sprite_0;

		// Token: 0x04000879 RID: 2169
		private static readonly IntPtr NativeMethodInfoPtr_get_BusyColor_Public_get_Color_0;

		// Token: 0x0400087A RID: 2170
		private static readonly IntPtr NativeMethodInfoPtr_set_BusyColor_Public_set_Void_Color_0;

		// Token: 0x0400087B RID: 2171
		private static readonly IntPtr NativeMethodInfoPtr_get_IdleColor_Public_get_Color_0;

		// Token: 0x0400087C RID: 2172
		private static readonly IntPtr NativeMethodInfoPtr_set_IdleColor_Public_set_Void_Color_0;

		// Token: 0x0400087D RID: 2173
		private static readonly IntPtr NativeMethodInfoPtr_get_Shape_Public_get_TouchSpriteShape_0;

		// Token: 0x0400087E RID: 2174
		private static readonly IntPtr NativeMethodInfoPtr_set_Shape_Public_set_Void_TouchSpriteShape_0;

		// Token: 0x0400087F RID: 2175
		private static readonly IntPtr NativeMethodInfoPtr_get_SizeUnitType_Public_get_TouchUnitType_0;

		// Token: 0x04000880 RID: 2176
		private static readonly IntPtr NativeMethodInfoPtr_set_SizeUnitType_Public_set_Void_TouchUnitType_0;

		// Token: 0x04000881 RID: 2177
		private static readonly IntPtr NativeMethodInfoPtr_get_Size_Public_get_Vector2_0;

		// Token: 0x04000882 RID: 2178
		private static readonly IntPtr NativeMethodInfoPtr_set_Size_Public_set_Void_Vector2_0;

		// Token: 0x04000883 RID: 2179
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldSize_Public_get_Vector2_0;

		// Token: 0x04000884 RID: 2180
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_get_Vector3_0;

		// Token: 0x04000885 RID: 2181
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0;
	}
}
