using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;
using voodoo;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x02000123 RID: 291
	public class WormFactionImageRenderer : VersionedDataComponentObserver<WormFactionData>
	{
		// Token: 0x06000D50 RID: 3408 RVA: 0x000406BC File Offset: 0x0003E8BC
		// Note: this type is marked as 'beforefieldinit'.
		static WormFactionImageRenderer()
		{
			Il2CppClassPointerStore<WormFactionImageRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormFactionImageRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormFactionImageRenderer>.NativeClassPtr);
			WormFactionImageRenderer.NativeFieldInfoPtr_atlasName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionImageRenderer>.NativeClassPtr, "atlasName");
			WormFactionImageRenderer.NativeFieldInfoPtr_spriteNameFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionImageRenderer>.NativeClassPtr, "spriteNameFormat");
			WormFactionImageRenderer.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFactionImageRenderer>.NativeClassPtr, "image");
			WormFactionImageRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionImageRenderer>.NativeClassPtr, 100665120);
			WormFactionImageRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionImageRenderer>.NativeClassPtr, 100665121);
			WormFactionImageRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFactionImageRenderer>.NativeClassPtr, 100665122);
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00040764 File Offset: 0x0003E964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705509, XrefRangeEnd = 705514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormFactionImageRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x000407A0 File Offset: 0x0003E9A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705514, XrefRangeEnd = 705532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormFactionImageRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x000407DC File Offset: 0x0003E9DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705532, XrefRangeEnd = 705540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormFactionImageRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormFactionImageRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFactionImageRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x000090B1 File Offset: 0x000072B1
		public WormFactionImageRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000D55 RID: 3413 RVA: 0x00040818 File Offset: 0x0003EA18
		// (set) Token: 0x06000D56 RID: 3414 RVA: 0x000090BA File Offset: 0x000072BA
		public unsafe string atlasName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionImageRenderer.NativeFieldInfoPtr_atlasName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionImageRenderer.NativeFieldInfoPtr_atlasName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000D57 RID: 3415 RVA: 0x00040840 File Offset: 0x0003EA40
		// (set) Token: 0x06000D58 RID: 3416 RVA: 0x000090D9 File Offset: 0x000072D9
		public unsafe string spriteNameFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionImageRenderer.NativeFieldInfoPtr_spriteNameFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionImageRenderer.NativeFieldInfoPtr_spriteNameFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000D59 RID: 3417 RVA: 0x00040868 File Offset: 0x0003EA68
		// (set) Token: 0x06000D5A RID: 3418 RVA: 0x000090F8 File Offset: 0x000072F8
		public unsafe Image image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionImageRenderer.NativeFieldInfoPtr_image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFactionImageRenderer.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007B5 RID: 1973
		private static readonly IntPtr NativeFieldInfoPtr_atlasName;

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeFieldInfoPtr_spriteNameFormat;

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeFieldInfoPtr_image;

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040007B9 RID: 1977
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x040007BA RID: 1978
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
