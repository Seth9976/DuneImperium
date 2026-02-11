using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Unity.Properties.Internal
{
	// Token: 0x02000028 RID: 40
	public class Vector4PropertyBag : ContainerPropertyBag<Vector4>
	{
		// Token: 0x06000155 RID: 341 RVA: 0x000029FE File Offset: 0x00000BFE
		// Note: this type is marked as 'beforefieldinit'.
		static Vector4PropertyBag()
		{
			Il2CppClassPointerStore<Vector4PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties.Internal", "Vector4PropertyBag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector4PropertyBag>.NativeClassPtr);
			Vector4PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4PropertyBag>.NativeClassPtr, 100663469);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000073F4 File Offset: 0x000055F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232169, XrefRangeEnd = 1232208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4PropertyBag()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector4PropertyBag>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002A37 File Offset: 0x00000C37
		public Vector4PropertyBag(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000084 RID: 132
		public class XProperty : Property<Vector4, float>
		{
			// Token: 0x0600027F RID: 639 RVA: 0x0000A984 File Offset: 0x00008B84
			// Note: this type is marked as 'beforefieldinit'.
			static XProperty()
			{
				Il2CppClassPointerStore<Vector4PropertyBag.XProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Vector4PropertyBag>.NativeClassPtr, "XProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector4PropertyBag.XProperty>.NativeClassPtr);
				Vector4PropertyBag.XProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4PropertyBag.XProperty>.NativeClassPtr, 100663470);
				Vector4PropertyBag.XProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4PropertyBag.XProperty>.NativeClassPtr, 100663471);
			}

			// Token: 0x1700008A RID: 138
			// (get) Token: 0x06000280 RID: 640 RVA: 0x0000A9D8 File Offset: 0x00008BD8
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232149, XrefRangeEnd = 1232151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector4PropertyBag.XProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000281 RID: 641 RVA: 0x0000AA1C File Offset: 0x00008C1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232151, XrefRangeEnd = 1232154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector4PropertyBag.XProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4PropertyBag.XProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000282 RID: 642 RVA: 0x00003309 File Offset: 0x00001509
			public XProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400013B RID: 315
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

			// Token: 0x0400013C RID: 316
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000085 RID: 133
		public class YProperty : Property<Vector4, float>
		{
			// Token: 0x06000283 RID: 643 RVA: 0x0000AA58 File Offset: 0x00008C58
			// Note: this type is marked as 'beforefieldinit'.
			static YProperty()
			{
				Il2CppClassPointerStore<Vector4PropertyBag.YProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Vector4PropertyBag>.NativeClassPtr, "YProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector4PropertyBag.YProperty>.NativeClassPtr);
				Vector4PropertyBag.YProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4PropertyBag.YProperty>.NativeClassPtr, 100663472);
				Vector4PropertyBag.YProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4PropertyBag.YProperty>.NativeClassPtr, 100663473);
			}

			// Token: 0x1700008B RID: 139
			// (get) Token: 0x06000284 RID: 644 RVA: 0x0000AAAC File Offset: 0x00008CAC
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232154, XrefRangeEnd = 1232156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector4PropertyBag.YProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000285 RID: 645 RVA: 0x0000AAF0 File Offset: 0x00008CF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232156, XrefRangeEnd = 1232159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe YProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector4PropertyBag.YProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4PropertyBag.YProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000286 RID: 646 RVA: 0x00003312 File Offset: 0x00001512
			public YProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400013D RID: 317
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

			// Token: 0x0400013E RID: 318
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000086 RID: 134
		public class ZProperty : Property<Vector4, float>
		{
			// Token: 0x06000287 RID: 647 RVA: 0x0000AB2C File Offset: 0x00008D2C
			// Note: this type is marked as 'beforefieldinit'.
			static ZProperty()
			{
				Il2CppClassPointerStore<Vector4PropertyBag.ZProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Vector4PropertyBag>.NativeClassPtr, "ZProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector4PropertyBag.ZProperty>.NativeClassPtr);
				Vector4PropertyBag.ZProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4PropertyBag.ZProperty>.NativeClassPtr, 100663474);
				Vector4PropertyBag.ZProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4PropertyBag.ZProperty>.NativeClassPtr, 100663475);
			}

			// Token: 0x1700008C RID: 140
			// (get) Token: 0x06000288 RID: 648 RVA: 0x0000AB80 File Offset: 0x00008D80
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232159, XrefRangeEnd = 1232161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector4PropertyBag.ZProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000289 RID: 649 RVA: 0x0000ABC4 File Offset: 0x00008DC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232161, XrefRangeEnd = 1232164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ZProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector4PropertyBag.ZProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4PropertyBag.ZProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600028A RID: 650 RVA: 0x0000331B File Offset: 0x0000151B
			public ZProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400013F RID: 319
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

			// Token: 0x04000140 RID: 320
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000087 RID: 135
		public class WProperty : Property<Vector4, float>
		{
			// Token: 0x0600028B RID: 651 RVA: 0x0000AC00 File Offset: 0x00008E00
			// Note: this type is marked as 'beforefieldinit'.
			static WProperty()
			{
				Il2CppClassPointerStore<Vector4PropertyBag.WProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Vector4PropertyBag>.NativeClassPtr, "WProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector4PropertyBag.WProperty>.NativeClassPtr);
				Vector4PropertyBag.WProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4PropertyBag.WProperty>.NativeClassPtr, 100663476);
				Vector4PropertyBag.WProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4PropertyBag.WProperty>.NativeClassPtr, 100663477);
			}

			// Token: 0x1700008D RID: 141
			// (get) Token: 0x0600028C RID: 652 RVA: 0x0000AC54 File Offset: 0x00008E54
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232164, XrefRangeEnd = 1232166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector4PropertyBag.WProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600028D RID: 653 RVA: 0x0000AC98 File Offset: 0x00008E98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232166, XrefRangeEnd = 1232169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector4PropertyBag.WProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4PropertyBag.WProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600028E RID: 654 RVA: 0x00003324 File Offset: 0x00001524
			public WProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000141 RID: 321
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

			// Token: 0x04000142 RID: 322
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
