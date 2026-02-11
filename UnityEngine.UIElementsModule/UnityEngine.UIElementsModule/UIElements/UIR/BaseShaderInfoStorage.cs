using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000267 RID: 615
	public class BaseShaderInfoStorage : Object
	{
		// Token: 0x06002DA7 RID: 11687 RVA: 0x000C3398 File Offset: 0x000C1598
		// Note: this type is marked as 'beforefieldinit'.
		static BaseShaderInfoStorage()
		{
			Il2CppClassPointerStore<BaseShaderInfoStorage>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "BaseShaderInfoStorage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseShaderInfoStorage>.NativeClassPtr);
			BaseShaderInfoStorage.NativeFieldInfoPtr_s_TextureCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseShaderInfoStorage>.NativeClassPtr, "s_TextureCounter");
			BaseShaderInfoStorage.NativeFieldInfoPtr_s_MarkerCopyTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseShaderInfoStorage>.NativeClassPtr, "s_MarkerCopyTexture");
			BaseShaderInfoStorage.NativeFieldInfoPtr_s_MarkerGetTextureData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseShaderInfoStorage>.NativeClassPtr, "s_MarkerGetTextureData");
			BaseShaderInfoStorage.NativeFieldInfoPtr_s_MarkerUpdateTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseShaderInfoStorage>.NativeClassPtr, "s_MarkerUpdateTexture");
			BaseShaderInfoStorage.NativeFieldInfoPtr__disposed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseShaderInfoStorage>.NativeClassPtr, "<disposed>k__BackingField");
			BaseShaderInfoStorage.NativeMethodInfoPtr_get_texture_Public_Abstract_Virtual_New_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseShaderInfoStorage>.NativeClassPtr, 100669966);
			BaseShaderInfoStorage.NativeMethodInfoPtr_AllocateRect_Public_Abstract_Virtual_New_Boolean_Int32_Int32_byref_RectInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseShaderInfoStorage>.NativeClassPtr, 100669967);
			BaseShaderInfoStorage.NativeMethodInfoPtr_SetTexel_Public_Abstract_Virtual_New_Void_Int32_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseShaderInfoStorage>.NativeClassPtr, 100669968);
			BaseShaderInfoStorage.NativeMethodInfoPtr_UpdateTexture_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseShaderInfoStorage>.NativeClassPtr, 100669969);
			BaseShaderInfoStorage.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseShaderInfoStorage>.NativeClassPtr, 100669970);
			BaseShaderInfoStorage.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseShaderInfoStorage>.NativeClassPtr, 100669971);
			BaseShaderInfoStorage.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseShaderInfoStorage>.NativeClassPtr, 100669972);
			BaseShaderInfoStorage.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseShaderInfoStorage>.NativeClassPtr, 100669973);
			BaseShaderInfoStorage.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseShaderInfoStorage>.NativeClassPtr, 100669974);
		}

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x06002DA8 RID: 11688 RVA: 0x000C34E0 File Offset: 0x000C16E0
		public unsafe virtual Texture2D texture
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseShaderInfoStorage.NativeMethodInfoPtr_get_texture_Public_Abstract_Virtual_New_get_Texture2D_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x06002DA9 RID: 11689 RVA: 0x000C352C File Offset: 0x000C172C
		[CallerCount(0)]
		public unsafe virtual bool AllocateRect(int width, int height, out RectInt uvs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &uvs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseShaderInfoStorage.NativeMethodInfoPtr_AllocateRect_Public_Abstract_Virtual_New_Boolean_Int32_Int32_byref_RectInt_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002DAA RID: 11690 RVA: 0x000C359C File Offset: 0x000C179C
		[CallerCount(0)]
		public unsafe virtual void SetTexel(int x, int y, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseShaderInfoStorage.NativeMethodInfoPtr_SetTexel_Public_Abstract_Virtual_New_Void_Int32_Int32_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DAB RID: 11691 RVA: 0x000C3604 File Offset: 0x000C1804
		[CallerCount(0)]
		public unsafe virtual void UpdateTexture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseShaderInfoStorage.NativeMethodInfoPtr_UpdateTexture_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x06002DAC RID: 11692 RVA: 0x000C3640 File Offset: 0x000C1840
		// (set) Token: 0x06002DAD RID: 11693 RVA: 0x000C367C File Offset: 0x000C187C
		public unsafe bool disposed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseShaderInfoStorage.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseShaderInfoStorage.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002DAE RID: 11694 RVA: 0x000C36BC File Offset: 0x000C18BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351522, XrefRangeEnd = 351539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseShaderInfoStorage.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x000C36F0 File Offset: 0x000C18F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 351539, RefRangeEnd = 351540, XrefRangeStart = 351539, XrefRangeEnd = 351539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseShaderInfoStorage.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DB0 RID: 11696 RVA: 0x000C373C File Offset: 0x000C193C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseShaderInfoStorage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseShaderInfoStorage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseShaderInfoStorage.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DB1 RID: 11697 RVA: 0x00012BFD File Offset: 0x00010DFD
		public BaseShaderInfoStorage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x06002DB2 RID: 11698 RVA: 0x000C3778 File Offset: 0x000C1978
		// (set) Token: 0x06002DB3 RID: 11699 RVA: 0x00012C06 File Offset: 0x00010E06
		public unsafe static int s_TextureCounter
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(BaseShaderInfoStorage.NativeFieldInfoPtr_s_TextureCounter, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseShaderInfoStorage.NativeFieldInfoPtr_s_TextureCounter, (void*)(&value));
			}
		}

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x06002DB4 RID: 11700 RVA: 0x000C3794 File Offset: 0x000C1994
		// (set) Token: 0x06002DB5 RID: 11701 RVA: 0x00012C14 File Offset: 0x00010E14
		public unsafe static ProfilerMarker s_MarkerCopyTexture
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(BaseShaderInfoStorage.NativeFieldInfoPtr_s_MarkerCopyTexture, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseShaderInfoStorage.NativeFieldInfoPtr_s_MarkerCopyTexture, (void*)(&value));
			}
		}

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x06002DB6 RID: 11702 RVA: 0x000C37B0 File Offset: 0x000C19B0
		// (set) Token: 0x06002DB7 RID: 11703 RVA: 0x00012C22 File Offset: 0x00010E22
		public unsafe static ProfilerMarker s_MarkerGetTextureData
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(BaseShaderInfoStorage.NativeFieldInfoPtr_s_MarkerGetTextureData, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseShaderInfoStorage.NativeFieldInfoPtr_s_MarkerGetTextureData, (void*)(&value));
			}
		}

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x06002DB8 RID: 11704 RVA: 0x000C37CC File Offset: 0x000C19CC
		// (set) Token: 0x06002DB9 RID: 11705 RVA: 0x00012C30 File Offset: 0x00010E30
		public unsafe static ProfilerMarker s_MarkerUpdateTexture
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(BaseShaderInfoStorage.NativeFieldInfoPtr_s_MarkerUpdateTexture, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseShaderInfoStorage.NativeFieldInfoPtr_s_MarkerUpdateTexture, (void*)(&value));
			}
		}

		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x06002DBA RID: 11706 RVA: 0x000C37E8 File Offset: 0x000C19E8
		// (set) Token: 0x06002DBB RID: 11707 RVA: 0x00012C3E File Offset: 0x00010E3E
		public unsafe bool _disposed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseShaderInfoStorage.NativeFieldInfoPtr__disposed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseShaderInfoStorage.NativeFieldInfoPtr__disposed_k__BackingField)) = value;
			}
		}

		// Token: 0x040020DE RID: 8414
		private static readonly IntPtr NativeFieldInfoPtr_s_TextureCounter;

		// Token: 0x040020DF RID: 8415
		private static readonly IntPtr NativeFieldInfoPtr_s_MarkerCopyTexture;

		// Token: 0x040020E0 RID: 8416
		private static readonly IntPtr NativeFieldInfoPtr_s_MarkerGetTextureData;

		// Token: 0x040020E1 RID: 8417
		private static readonly IntPtr NativeFieldInfoPtr_s_MarkerUpdateTexture;

		// Token: 0x040020E2 RID: 8418
		private static readonly IntPtr NativeFieldInfoPtr__disposed_k__BackingField;

		// Token: 0x040020E3 RID: 8419
		private static readonly IntPtr NativeMethodInfoPtr_get_texture_Public_Abstract_Virtual_New_get_Texture2D_0;

		// Token: 0x040020E4 RID: 8420
		private static readonly IntPtr NativeMethodInfoPtr_AllocateRect_Public_Abstract_Virtual_New_Boolean_Int32_Int32_byref_RectInt_0;

		// Token: 0x040020E5 RID: 8421
		private static readonly IntPtr NativeMethodInfoPtr_SetTexel_Public_Abstract_Virtual_New_Void_Int32_Int32_Color_0;

		// Token: 0x040020E6 RID: 8422
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTexture_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040020E7 RID: 8423
		private static readonly IntPtr NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0;

		// Token: 0x040020E8 RID: 8424
		private static readonly IntPtr NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0;

		// Token: 0x040020E9 RID: 8425
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040020EA RID: 8426
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x040020EB RID: 8427
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
