using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200021C RID: 540
	[Serializable]
	public class VectorImage : ScriptableObject
	{
		// Token: 0x060028FA RID: 10490 RVA: 0x000B3A7C File Offset: 0x000B1C7C
		// Note: this type is marked as 'beforefieldinit'.
		static VectorImage()
		{
			Il2CppClassPointerStore<VectorImage>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "VectorImage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VectorImage>.NativeClassPtr);
			VectorImage.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImage>.NativeClassPtr, "version");
			VectorImage.NativeFieldInfoPtr_atlas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImage>.NativeClassPtr, "atlas");
			VectorImage.NativeFieldInfoPtr_vertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImage>.NativeClassPtr, "vertices");
			VectorImage.NativeFieldInfoPtr_indices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImage>.NativeClassPtr, "indices");
			VectorImage.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImage>.NativeClassPtr, "settings");
			VectorImage.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImage>.NativeClassPtr, "size");
			VectorImage.NativeMethodInfoPtr_get_width_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorImage>.NativeClassPtr, 100669460);
			VectorImage.NativeMethodInfoPtr_get_height_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorImage>.NativeClassPtr, 100669461);
			VectorImage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorImage>.NativeClassPtr, 100669462);
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x060028FB RID: 10491 RVA: 0x000B3B60 File Offset: 0x000B1D60
		public unsafe float width
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300360, RefRangeEnd = 300361, XrefRangeStart = 300360, XrefRangeEnd = 300361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorImage.NativeMethodInfoPtr_get_width_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x060028FC RID: 10492 RVA: 0x000B3B9C File Offset: 0x000B1D9C
		public unsafe float height
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300359, RefRangeEnd = 300360, XrefRangeStart = 300359, XrefRangeEnd = 300360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorImage.NativeMethodInfoPtr_get_height_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028FD RID: 10493 RVA: 0x000B3BD8 File Offset: 0x000B1DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346054, XrefRangeEnd = 346061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VectorImage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VectorImage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorImage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028FE RID: 10494 RVA: 0x00010872 File Offset: 0x0000EA72
		public VectorImage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x060028FF RID: 10495 RVA: 0x000B3C14 File Offset: 0x000B1E14
		// (set) Token: 0x06002900 RID: 10496 RVA: 0x0001087B File Offset: 0x0000EA7B
		public unsafe int version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImage.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImage.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x06002901 RID: 10497 RVA: 0x000B3C3C File Offset: 0x000B1E3C
		// (set) Token: 0x06002902 RID: 10498 RVA: 0x00010896 File Offset: 0x0000EA96
		public unsafe Texture2D atlas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImage.NativeFieldInfoPtr_atlas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImage.NativeFieldInfoPtr_atlas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x06002903 RID: 10499 RVA: 0x000B3C6C File Offset: 0x000B1E6C
		// (set) Token: 0x06002904 RID: 10500 RVA: 0x000108B5 File Offset: 0x0000EAB5
		public unsafe Il2CppStructArray<VectorImageVertex> vertices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImage.NativeFieldInfoPtr_vertices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<VectorImageVertex>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImage.NativeFieldInfoPtr_vertices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x06002905 RID: 10501 RVA: 0x000B3C9C File Offset: 0x000B1E9C
		// (set) Token: 0x06002906 RID: 10502 RVA: 0x000108D4 File Offset: 0x0000EAD4
		public unsafe Il2CppStructArray<ushort> indices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImage.NativeFieldInfoPtr_indices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImage.NativeFieldInfoPtr_indices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x06002907 RID: 10503 RVA: 0x000B3CCC File Offset: 0x000B1ECC
		// (set) Token: 0x06002908 RID: 10504 RVA: 0x000108F3 File Offset: 0x0000EAF3
		public unsafe Il2CppStructArray<GradientSettings> settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImage.NativeFieldInfoPtr_settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GradientSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImage.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x06002909 RID: 10505 RVA: 0x000B3CFC File Offset: 0x000B1EFC
		// (set) Token: 0x0600290A RID: 10506 RVA: 0x00010912 File Offset: 0x0000EB12
		public unsafe Vector2 size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImage.NativeFieldInfoPtr_size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImage.NativeFieldInfoPtr_size)) = value;
			}
		}

		// Token: 0x04001D09 RID: 7433
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x04001D0A RID: 7434
		private static readonly IntPtr NativeFieldInfoPtr_atlas;

		// Token: 0x04001D0B RID: 7435
		private static readonly IntPtr NativeFieldInfoPtr_vertices;

		// Token: 0x04001D0C RID: 7436
		private static readonly IntPtr NativeFieldInfoPtr_indices;

		// Token: 0x04001D0D RID: 7437
		private static readonly IntPtr NativeFieldInfoPtr_settings;

		// Token: 0x04001D0E RID: 7438
		private static readonly IntPtr NativeFieldInfoPtr_size;

		// Token: 0x04001D0F RID: 7439
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_get_Single_0;

		// Token: 0x04001D10 RID: 7440
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_get_Single_0;

		// Token: 0x04001D11 RID: 7441
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
