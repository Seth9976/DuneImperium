using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Unity.Properties.Internal
{
	// Token: 0x0200002A RID: 42
	public class Vector3IntPropertyBag : ContainerPropertyBag<Vector3Int>
	{
		// Token: 0x0600015B RID: 347 RVA: 0x00002A82 File Offset: 0x00000C82
		// Note: this type is marked as 'beforefieldinit'.
		static Vector3IntPropertyBag()
		{
			Il2CppClassPointerStore<Vector3IntPropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties.Internal", "Vector3IntPropertyBag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector3IntPropertyBag>.NativeClassPtr);
			Vector3IntPropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3IntPropertyBag>.NativeClassPtr, 100663483);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000746C File Offset: 0x0000566C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232256, XrefRangeEnd = 1232287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3IntPropertyBag()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector3IntPropertyBag>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3IntPropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002ABB File Offset: 0x00000CBB
		public Vector3IntPropertyBag(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200008A RID: 138
		public class XProperty : Property<Vector3Int, int>
		{
			// Token: 0x06000297 RID: 663 RVA: 0x0000AE7C File Offset: 0x0000907C
			// Note: this type is marked as 'beforefieldinit'.
			static XProperty()
			{
				Il2CppClassPointerStore<Vector3IntPropertyBag.XProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Vector3IntPropertyBag>.NativeClassPtr, "XProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector3IntPropertyBag.XProperty>.NativeClassPtr);
				Vector3IntPropertyBag.XProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3IntPropertyBag.XProperty>.NativeClassPtr, 100663484);
				Vector3IntPropertyBag.XProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3IntPropertyBag.XProperty>.NativeClassPtr, 100663485);
			}

			// Token: 0x17000090 RID: 144
			// (get) Token: 0x06000298 RID: 664 RVA: 0x0000AED0 File Offset: 0x000090D0
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232241, XrefRangeEnd = 1232243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector3IntPropertyBag.XProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000299 RID: 665 RVA: 0x0000AF14 File Offset: 0x00009114
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232243, XrefRangeEnd = 1232246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector3IntPropertyBag.XProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3IntPropertyBag.XProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600029A RID: 666 RVA: 0x0000333F File Offset: 0x0000153F
			public XProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000147 RID: 327
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

			// Token: 0x04000148 RID: 328
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200008B RID: 139
		public class YProperty : Property<Vector3Int, int>
		{
			// Token: 0x0600029B RID: 667 RVA: 0x0000AF50 File Offset: 0x00009150
			// Note: this type is marked as 'beforefieldinit'.
			static YProperty()
			{
				Il2CppClassPointerStore<Vector3IntPropertyBag.YProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Vector3IntPropertyBag>.NativeClassPtr, "YProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector3IntPropertyBag.YProperty>.NativeClassPtr);
				Vector3IntPropertyBag.YProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3IntPropertyBag.YProperty>.NativeClassPtr, 100663486);
				Vector3IntPropertyBag.YProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3IntPropertyBag.YProperty>.NativeClassPtr, 100663487);
			}

			// Token: 0x17000091 RID: 145
			// (get) Token: 0x0600029C RID: 668 RVA: 0x0000AFA4 File Offset: 0x000091A4
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232246, XrefRangeEnd = 1232248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector3IntPropertyBag.YProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600029D RID: 669 RVA: 0x0000AFE8 File Offset: 0x000091E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232248, XrefRangeEnd = 1232251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe YProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector3IntPropertyBag.YProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3IntPropertyBag.YProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600029E RID: 670 RVA: 0x00003348 File Offset: 0x00001548
			public YProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000149 RID: 329
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

			// Token: 0x0400014A RID: 330
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200008C RID: 140
		public class ZProperty : Property<Vector3Int, int>
		{
			// Token: 0x0600029F RID: 671 RVA: 0x0000B024 File Offset: 0x00009224
			// Note: this type is marked as 'beforefieldinit'.
			static ZProperty()
			{
				Il2CppClassPointerStore<Vector3IntPropertyBag.ZProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Vector3IntPropertyBag>.NativeClassPtr, "ZProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector3IntPropertyBag.ZProperty>.NativeClassPtr);
				Vector3IntPropertyBag.ZProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3IntPropertyBag.ZProperty>.NativeClassPtr, 100663488);
				Vector3IntPropertyBag.ZProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3IntPropertyBag.ZProperty>.NativeClassPtr, 100663489);
			}

			// Token: 0x17000092 RID: 146
			// (get) Token: 0x060002A0 RID: 672 RVA: 0x0000B078 File Offset: 0x00009278
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232251, XrefRangeEnd = 1232253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector3IntPropertyBag.ZProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060002A1 RID: 673 RVA: 0x0000B0BC File Offset: 0x000092BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232253, XrefRangeEnd = 1232256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ZProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector3IntPropertyBag.ZProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3IntPropertyBag.ZProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002A2 RID: 674 RVA: 0x00003351 File Offset: 0x00001551
			public ZProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400014B RID: 331
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

			// Token: 0x0400014C RID: 332
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
