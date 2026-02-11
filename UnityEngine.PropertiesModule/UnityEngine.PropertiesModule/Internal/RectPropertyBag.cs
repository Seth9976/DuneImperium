using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Unity.Properties.Internal
{
	// Token: 0x0200002B RID: 43
	public class RectPropertyBag : ContainerPropertyBag<Rect>
	{
		// Token: 0x0600015E RID: 350 RVA: 0x00002AC4 File Offset: 0x00000CC4
		// Note: this type is marked as 'beforefieldinit'.
		static RectPropertyBag()
		{
			Il2CppClassPointerStore<RectPropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties.Internal", "RectPropertyBag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectPropertyBag>.NativeClassPtr);
			RectPropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectPropertyBag>.NativeClassPtr, 100663490);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000074A8 File Offset: 0x000056A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232307, XrefRangeEnd = 1232346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectPropertyBag()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectPropertyBag>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectPropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002AFD File Offset: 0x00000CFD
		public RectPropertyBag(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200008D RID: 141
		public class XProperty : Property<Rect, float>
		{
			// Token: 0x060002A3 RID: 675 RVA: 0x0000B0F8 File Offset: 0x000092F8
			// Note: this type is marked as 'beforefieldinit'.
			static XProperty()
			{
				Il2CppClassPointerStore<RectPropertyBag.XProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RectPropertyBag>.NativeClassPtr, "XProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectPropertyBag.XProperty>.NativeClassPtr);
				RectPropertyBag.XProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectPropertyBag.XProperty>.NativeClassPtr, 100663491);
				RectPropertyBag.XProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectPropertyBag.XProperty>.NativeClassPtr, 100663492);
			}

			// Token: 0x17000093 RID: 147
			// (get) Token: 0x060002A4 RID: 676 RVA: 0x0000B14C File Offset: 0x0000934C
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232287, XrefRangeEnd = 1232289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectPropertyBag.XProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060002A5 RID: 677 RVA: 0x0000B190 File Offset: 0x00009390
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232289, XrefRangeEnd = 1232292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectPropertyBag.XProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectPropertyBag.XProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002A6 RID: 678 RVA: 0x0000335A File Offset: 0x0000155A
			public XProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400014D RID: 333
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

			// Token: 0x0400014E RID: 334
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200008E RID: 142
		public class YProperty : Property<Rect, float>
		{
			// Token: 0x060002A7 RID: 679 RVA: 0x0000B1CC File Offset: 0x000093CC
			// Note: this type is marked as 'beforefieldinit'.
			static YProperty()
			{
				Il2CppClassPointerStore<RectPropertyBag.YProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RectPropertyBag>.NativeClassPtr, "YProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectPropertyBag.YProperty>.NativeClassPtr);
				RectPropertyBag.YProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectPropertyBag.YProperty>.NativeClassPtr, 100663493);
				RectPropertyBag.YProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectPropertyBag.YProperty>.NativeClassPtr, 100663494);
			}

			// Token: 0x17000094 RID: 148
			// (get) Token: 0x060002A8 RID: 680 RVA: 0x0000B220 File Offset: 0x00009420
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232292, XrefRangeEnd = 1232294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectPropertyBag.YProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060002A9 RID: 681 RVA: 0x0000B264 File Offset: 0x00009464
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232294, XrefRangeEnd = 1232297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe YProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectPropertyBag.YProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectPropertyBag.YProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002AA RID: 682 RVA: 0x00003363 File Offset: 0x00001563
			public YProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400014F RID: 335
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

			// Token: 0x04000150 RID: 336
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200008F RID: 143
		public class WidthProperty : Property<Rect, float>
		{
			// Token: 0x060002AB RID: 683 RVA: 0x0000B2A0 File Offset: 0x000094A0
			// Note: this type is marked as 'beforefieldinit'.
			static WidthProperty()
			{
				Il2CppClassPointerStore<RectPropertyBag.WidthProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RectPropertyBag>.NativeClassPtr, "WidthProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectPropertyBag.WidthProperty>.NativeClassPtr);
				RectPropertyBag.WidthProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectPropertyBag.WidthProperty>.NativeClassPtr, 100663495);
				RectPropertyBag.WidthProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectPropertyBag.WidthProperty>.NativeClassPtr, 100663496);
			}

			// Token: 0x17000095 RID: 149
			// (get) Token: 0x060002AC RID: 684 RVA: 0x0000B2F4 File Offset: 0x000094F4
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232297, XrefRangeEnd = 1232299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectPropertyBag.WidthProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060002AD RID: 685 RVA: 0x0000B338 File Offset: 0x00009538
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232299, XrefRangeEnd = 1232302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WidthProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectPropertyBag.WidthProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectPropertyBag.WidthProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002AE RID: 686 RVA: 0x0000336C File Offset: 0x0000156C
			public WidthProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000151 RID: 337
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

			// Token: 0x04000152 RID: 338
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000090 RID: 144
		public class HeightProperty : Property<Rect, float>
		{
			// Token: 0x060002AF RID: 687 RVA: 0x0000B374 File Offset: 0x00009574
			// Note: this type is marked as 'beforefieldinit'.
			static HeightProperty()
			{
				Il2CppClassPointerStore<RectPropertyBag.HeightProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RectPropertyBag>.NativeClassPtr, "HeightProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectPropertyBag.HeightProperty>.NativeClassPtr);
				RectPropertyBag.HeightProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectPropertyBag.HeightProperty>.NativeClassPtr, 100663497);
				RectPropertyBag.HeightProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectPropertyBag.HeightProperty>.NativeClassPtr, 100663498);
			}

			// Token: 0x17000096 RID: 150
			// (get) Token: 0x060002B0 RID: 688 RVA: 0x0000B3C8 File Offset: 0x000095C8
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232302, XrefRangeEnd = 1232304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectPropertyBag.HeightProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060002B1 RID: 689 RVA: 0x0000B40C File Offset: 0x0000960C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232304, XrefRangeEnd = 1232307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HeightProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectPropertyBag.HeightProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectPropertyBag.HeightProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002B2 RID: 690 RVA: 0x00003375 File Offset: 0x00001575
			public HeightProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000153 RID: 339
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

			// Token: 0x04000154 RID: 340
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
