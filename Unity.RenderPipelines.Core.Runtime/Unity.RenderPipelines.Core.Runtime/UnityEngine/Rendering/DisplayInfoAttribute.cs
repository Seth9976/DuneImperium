using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200003B RID: 59
	public class DisplayInfoAttribute : Attribute
	{
		// Token: 0x060004D4 RID: 1236 RVA: 0x0001F2B8 File Offset: 0x0001D4B8
		// Note: this type is marked as 'beforefieldinit'.
		static DisplayInfoAttribute()
		{
			Il2CppClassPointerStore<DisplayInfoAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "DisplayInfoAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisplayInfoAttribute>.NativeClassPtr);
			DisplayInfoAttribute.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayInfoAttribute>.NativeClassPtr, "name");
			DisplayInfoAttribute.NativeFieldInfoPtr_order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayInfoAttribute>.NativeClassPtr, "order");
			DisplayInfoAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayInfoAttribute>.NativeClassPtr, 100663890);
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x0001F324 File Offset: 0x0001D524
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DisplayInfoAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisplayInfoAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayInfoAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00003FF4 File Offset: 0x000021F4
		public DisplayInfoAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x0001F360 File Offset: 0x0001D560
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x00003FFD File Offset: 0x000021FD
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayInfoAttribute.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayInfoAttribute.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x0001F388 File Offset: 0x0001D588
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x0000401C File Offset: 0x0000221C
		public unsafe int order
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayInfoAttribute.NativeFieldInfoPtr_order);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayInfoAttribute.NativeFieldInfoPtr_order)) = value;
			}
		}

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeFieldInfoPtr_order;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
