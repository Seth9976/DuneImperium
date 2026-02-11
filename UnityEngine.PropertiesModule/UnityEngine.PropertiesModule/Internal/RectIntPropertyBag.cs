using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Unity.Properties.Internal
{
	// Token: 0x0200002C RID: 44
	public class RectIntPropertyBag : ContainerPropertyBag<RectInt>
	{
		// Token: 0x06000161 RID: 353 RVA: 0x00002B06 File Offset: 0x00000D06
		// Note: this type is marked as 'beforefieldinit'.
		static RectIntPropertyBag()
		{
			Il2CppClassPointerStore<RectIntPropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties.Internal", "RectIntPropertyBag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectIntPropertyBag>.NativeClassPtr);
			RectIntPropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectIntPropertyBag>.NativeClassPtr, 100663499);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000074E4 File Offset: 0x000056E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232366, XrefRangeEnd = 1232405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectIntPropertyBag()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectIntPropertyBag>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectIntPropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002B3F File Offset: 0x00000D3F
		public RectIntPropertyBag(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000091 RID: 145
		public class XProperty : Property<RectInt, int>
		{
			// Token: 0x060002B3 RID: 691 RVA: 0x0000B448 File Offset: 0x00009648
			// Note: this type is marked as 'beforefieldinit'.
			static XProperty()
			{
				Il2CppClassPointerStore<RectIntPropertyBag.XProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RectIntPropertyBag>.NativeClassPtr, "XProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectIntPropertyBag.XProperty>.NativeClassPtr);
				RectIntPropertyBag.XProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectIntPropertyBag.XProperty>.NativeClassPtr, 100663500);
				RectIntPropertyBag.XProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectIntPropertyBag.XProperty>.NativeClassPtr, 100663501);
			}

			// Token: 0x17000097 RID: 151
			// (get) Token: 0x060002B4 RID: 692 RVA: 0x0000B49C File Offset: 0x0000969C
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232346, XrefRangeEnd = 1232348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectIntPropertyBag.XProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060002B5 RID: 693 RVA: 0x0000B4E0 File Offset: 0x000096E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232348, XrefRangeEnd = 1232351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectIntPropertyBag.XProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectIntPropertyBag.XProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002B6 RID: 694 RVA: 0x0000337E File Offset: 0x0000157E
			public XProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000155 RID: 341
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

			// Token: 0x04000156 RID: 342
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000092 RID: 146
		public class YProperty : Property<RectInt, int>
		{
			// Token: 0x060002B7 RID: 695 RVA: 0x0000B51C File Offset: 0x0000971C
			// Note: this type is marked as 'beforefieldinit'.
			static YProperty()
			{
				Il2CppClassPointerStore<RectIntPropertyBag.YProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RectIntPropertyBag>.NativeClassPtr, "YProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectIntPropertyBag.YProperty>.NativeClassPtr);
				RectIntPropertyBag.YProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectIntPropertyBag.YProperty>.NativeClassPtr, 100663502);
				RectIntPropertyBag.YProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectIntPropertyBag.YProperty>.NativeClassPtr, 100663503);
			}

			// Token: 0x17000098 RID: 152
			// (get) Token: 0x060002B8 RID: 696 RVA: 0x0000B570 File Offset: 0x00009770
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232351, XrefRangeEnd = 1232353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectIntPropertyBag.YProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060002B9 RID: 697 RVA: 0x0000B5B4 File Offset: 0x000097B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232353, XrefRangeEnd = 1232356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe YProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectIntPropertyBag.YProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectIntPropertyBag.YProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002BA RID: 698 RVA: 0x00003387 File Offset: 0x00001587
			public YProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000157 RID: 343
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

			// Token: 0x04000158 RID: 344
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000093 RID: 147
		public class WidthProperty : Property<RectInt, int>
		{
			// Token: 0x060002BB RID: 699 RVA: 0x0000B5F0 File Offset: 0x000097F0
			// Note: this type is marked as 'beforefieldinit'.
			static WidthProperty()
			{
				Il2CppClassPointerStore<RectIntPropertyBag.WidthProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RectIntPropertyBag>.NativeClassPtr, "WidthProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectIntPropertyBag.WidthProperty>.NativeClassPtr);
				RectIntPropertyBag.WidthProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectIntPropertyBag.WidthProperty>.NativeClassPtr, 100663504);
				RectIntPropertyBag.WidthProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectIntPropertyBag.WidthProperty>.NativeClassPtr, 100663505);
			}

			// Token: 0x17000099 RID: 153
			// (get) Token: 0x060002BC RID: 700 RVA: 0x0000B644 File Offset: 0x00009844
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232356, XrefRangeEnd = 1232358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectIntPropertyBag.WidthProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060002BD RID: 701 RVA: 0x0000B688 File Offset: 0x00009888
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232358, XrefRangeEnd = 1232361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WidthProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectIntPropertyBag.WidthProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectIntPropertyBag.WidthProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002BE RID: 702 RVA: 0x00003390 File Offset: 0x00001590
			public WidthProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000159 RID: 345
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

			// Token: 0x0400015A RID: 346
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000094 RID: 148
		public class HeightProperty : Property<RectInt, int>
		{
			// Token: 0x060002BF RID: 703 RVA: 0x0000B6C4 File Offset: 0x000098C4
			// Note: this type is marked as 'beforefieldinit'.
			static HeightProperty()
			{
				Il2CppClassPointerStore<RectIntPropertyBag.HeightProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RectIntPropertyBag>.NativeClassPtr, "HeightProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectIntPropertyBag.HeightProperty>.NativeClassPtr);
				RectIntPropertyBag.HeightProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectIntPropertyBag.HeightProperty>.NativeClassPtr, 100663506);
				RectIntPropertyBag.HeightProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectIntPropertyBag.HeightProperty>.NativeClassPtr, 100663507);
			}

			// Token: 0x1700009A RID: 154
			// (get) Token: 0x060002C0 RID: 704 RVA: 0x0000B718 File Offset: 0x00009918
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232361, XrefRangeEnd = 1232363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectIntPropertyBag.HeightProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060002C1 RID: 705 RVA: 0x0000B75C File Offset: 0x0000995C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232363, XrefRangeEnd = 1232366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HeightProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectIntPropertyBag.HeightProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectIntPropertyBag.HeightProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002C2 RID: 706 RVA: 0x00003399 File Offset: 0x00001599
			public HeightProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400015B RID: 347
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

			// Token: 0x0400015C RID: 348
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
