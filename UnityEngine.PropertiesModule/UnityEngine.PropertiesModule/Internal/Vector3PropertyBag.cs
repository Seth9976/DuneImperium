using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Unity.Properties.Internal
{
	// Token: 0x02000027 RID: 39
	public class Vector3PropertyBag : ContainerPropertyBag<Vector3>
	{
		// Token: 0x06000152 RID: 338 RVA: 0x000029BC File Offset: 0x00000BBC
		// Note: this type is marked as 'beforefieldinit'.
		static Vector3PropertyBag()
		{
			Il2CppClassPointerStore<Vector3PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties.Internal", "Vector3PropertyBag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector3PropertyBag>.NativeClassPtr);
			Vector3PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3PropertyBag>.NativeClassPtr, 100663462);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000073B8 File Offset: 0x000055B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232118, XrefRangeEnd = 1232149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3PropertyBag()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector3PropertyBag>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000029F5 File Offset: 0x00000BF5
		public Vector3PropertyBag(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000081 RID: 129
		public class XProperty : Property<Vector3, float>
		{
			// Token: 0x06000273 RID: 627 RVA: 0x0000A708 File Offset: 0x00008908
			// Note: this type is marked as 'beforefieldinit'.
			static XProperty()
			{
				Il2CppClassPointerStore<Vector3PropertyBag.XProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Vector3PropertyBag>.NativeClassPtr, "XProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector3PropertyBag.XProperty>.NativeClassPtr);
				Vector3PropertyBag.XProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3PropertyBag.XProperty>.NativeClassPtr, 100663463);
				Vector3PropertyBag.XProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3PropertyBag.XProperty>.NativeClassPtr, 100663464);
			}

			// Token: 0x17000087 RID: 135
			// (get) Token: 0x06000274 RID: 628 RVA: 0x0000A75C File Offset: 0x0000895C
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232103, XrefRangeEnd = 1232105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector3PropertyBag.XProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000275 RID: 629 RVA: 0x0000A7A0 File Offset: 0x000089A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232105, XrefRangeEnd = 1232108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector3PropertyBag.XProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3PropertyBag.XProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000276 RID: 630 RVA: 0x000032EE File Offset: 0x000014EE
			public XProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000135 RID: 309
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

			// Token: 0x04000136 RID: 310
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000082 RID: 130
		public class YProperty : Property<Vector3, float>
		{
			// Token: 0x06000277 RID: 631 RVA: 0x0000A7DC File Offset: 0x000089DC
			// Note: this type is marked as 'beforefieldinit'.
			static YProperty()
			{
				Il2CppClassPointerStore<Vector3PropertyBag.YProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Vector3PropertyBag>.NativeClassPtr, "YProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector3PropertyBag.YProperty>.NativeClassPtr);
				Vector3PropertyBag.YProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3PropertyBag.YProperty>.NativeClassPtr, 100663465);
				Vector3PropertyBag.YProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3PropertyBag.YProperty>.NativeClassPtr, 100663466);
			}

			// Token: 0x17000088 RID: 136
			// (get) Token: 0x06000278 RID: 632 RVA: 0x0000A830 File Offset: 0x00008A30
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232108, XrefRangeEnd = 1232110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector3PropertyBag.YProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000279 RID: 633 RVA: 0x0000A874 File Offset: 0x00008A74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232110, XrefRangeEnd = 1232113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe YProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector3PropertyBag.YProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3PropertyBag.YProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600027A RID: 634 RVA: 0x000032F7 File Offset: 0x000014F7
			public YProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000137 RID: 311
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

			// Token: 0x04000138 RID: 312
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000083 RID: 131
		public class ZProperty : Property<Vector3, float>
		{
			// Token: 0x0600027B RID: 635 RVA: 0x0000A8B0 File Offset: 0x00008AB0
			// Note: this type is marked as 'beforefieldinit'.
			static ZProperty()
			{
				Il2CppClassPointerStore<Vector3PropertyBag.ZProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Vector3PropertyBag>.NativeClassPtr, "ZProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector3PropertyBag.ZProperty>.NativeClassPtr);
				Vector3PropertyBag.ZProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3PropertyBag.ZProperty>.NativeClassPtr, 100663467);
				Vector3PropertyBag.ZProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3PropertyBag.ZProperty>.NativeClassPtr, 100663468);
			}

			// Token: 0x17000089 RID: 137
			// (get) Token: 0x0600027C RID: 636 RVA: 0x0000A904 File Offset: 0x00008B04
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232113, XrefRangeEnd = 1232115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector3PropertyBag.ZProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600027D RID: 637 RVA: 0x0000A948 File Offset: 0x00008B48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232115, XrefRangeEnd = 1232118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ZProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector3PropertyBag.ZProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3PropertyBag.ZProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600027E RID: 638 RVA: 0x00003300 File Offset: 0x00001500
			public ZProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000139 RID: 313
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

			// Token: 0x0400013A RID: 314
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
