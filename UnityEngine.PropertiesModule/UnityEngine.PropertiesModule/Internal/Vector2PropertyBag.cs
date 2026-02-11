using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Unity.Properties.Internal
{
	// Token: 0x02000026 RID: 38
	public class Vector2PropertyBag : ContainerPropertyBag<Vector2>
	{
		// Token: 0x0600014F RID: 335 RVA: 0x0000297A File Offset: 0x00000B7A
		// Note: this type is marked as 'beforefieldinit'.
		static Vector2PropertyBag()
		{
			Il2CppClassPointerStore<Vector2PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties.Internal", "Vector2PropertyBag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector2PropertyBag>.NativeClassPtr);
			Vector2PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2PropertyBag>.NativeClassPtr, 100663457);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000737C File Offset: 0x0000557C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232080, XrefRangeEnd = 1232103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2PropertyBag()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector2PropertyBag>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000029B3 File Offset: 0x00000BB3
		public Vector2PropertyBag(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200007F RID: 127
		public class XProperty : Property<Vector2, float>
		{
			// Token: 0x0600026B RID: 619 RVA: 0x0000A560 File Offset: 0x00008760
			// Note: this type is marked as 'beforefieldinit'.
			static XProperty()
			{
				Il2CppClassPointerStore<Vector2PropertyBag.XProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Vector2PropertyBag>.NativeClassPtr, "XProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector2PropertyBag.XProperty>.NativeClassPtr);
				Vector2PropertyBag.XProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2PropertyBag.XProperty>.NativeClassPtr, 100663458);
				Vector2PropertyBag.XProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2PropertyBag.XProperty>.NativeClassPtr, 100663459);
			}

			// Token: 0x17000085 RID: 133
			// (get) Token: 0x0600026C RID: 620 RVA: 0x0000A5B4 File Offset: 0x000087B4
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232070, XrefRangeEnd = 1232072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector2PropertyBag.XProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600026D RID: 621 RVA: 0x0000A5F8 File Offset: 0x000087F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232072, XrefRangeEnd = 1232075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector2PropertyBag.XProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2PropertyBag.XProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600026E RID: 622 RVA: 0x000032DC File Offset: 0x000014DC
			public XProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000131 RID: 305
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

			// Token: 0x04000132 RID: 306
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000080 RID: 128
		public class YProperty : Property<Vector2, float>
		{
			// Token: 0x0600026F RID: 623 RVA: 0x0000A634 File Offset: 0x00008834
			// Note: this type is marked as 'beforefieldinit'.
			static YProperty()
			{
				Il2CppClassPointerStore<Vector2PropertyBag.YProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Vector2PropertyBag>.NativeClassPtr, "YProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector2PropertyBag.YProperty>.NativeClassPtr);
				Vector2PropertyBag.YProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2PropertyBag.YProperty>.NativeClassPtr, 100663460);
				Vector2PropertyBag.YProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2PropertyBag.YProperty>.NativeClassPtr, 100663461);
			}

			// Token: 0x17000086 RID: 134
			// (get) Token: 0x06000270 RID: 624 RVA: 0x0000A688 File Offset: 0x00008888
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232075, XrefRangeEnd = 1232077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector2PropertyBag.YProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000271 RID: 625 RVA: 0x0000A6CC File Offset: 0x000088CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232077, XrefRangeEnd = 1232080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe YProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector2PropertyBag.YProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2PropertyBag.YProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000272 RID: 626 RVA: 0x000032E5 File Offset: 0x000014E5
			public YProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000133 RID: 307
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

			// Token: 0x04000134 RID: 308
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
