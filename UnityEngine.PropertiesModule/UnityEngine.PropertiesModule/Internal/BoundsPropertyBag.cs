using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Unity.Properties.Internal
{
	// Token: 0x0200002D RID: 45
	public class BoundsPropertyBag : ContainerPropertyBag<Bounds>
	{
		// Token: 0x06000164 RID: 356 RVA: 0x00002B48 File Offset: 0x00000D48
		// Note: this type is marked as 'beforefieldinit'.
		static BoundsPropertyBag()
		{
			Il2CppClassPointerStore<BoundsPropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties.Internal", "BoundsPropertyBag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoundsPropertyBag>.NativeClassPtr);
			BoundsPropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsPropertyBag>.NativeClassPtr, 100663508);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00007520 File Offset: 0x00005720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232415, XrefRangeEnd = 1232438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoundsPropertyBag()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoundsPropertyBag>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsPropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002B81 File Offset: 0x00000D81
		public BoundsPropertyBag(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000095 RID: 149
		public class CenterProperty : Property<Bounds, Vector3>
		{
			// Token: 0x060002C3 RID: 707 RVA: 0x0000B798 File Offset: 0x00009998
			// Note: this type is marked as 'beforefieldinit'.
			static CenterProperty()
			{
				Il2CppClassPointerStore<BoundsPropertyBag.CenterProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BoundsPropertyBag>.NativeClassPtr, "CenterProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoundsPropertyBag.CenterProperty>.NativeClassPtr);
				BoundsPropertyBag.CenterProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsPropertyBag.CenterProperty>.NativeClassPtr, 100663509);
				BoundsPropertyBag.CenterProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsPropertyBag.CenterProperty>.NativeClassPtr, 100663510);
			}

			// Token: 0x1700009B RID: 155
			// (get) Token: 0x060002C4 RID: 708 RVA: 0x0000B7EC File Offset: 0x000099EC
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232405, XrefRangeEnd = 1232407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoundsPropertyBag.CenterProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060002C5 RID: 709 RVA: 0x0000B830 File Offset: 0x00009A30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232407, XrefRangeEnd = 1232410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CenterProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoundsPropertyBag.CenterProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsPropertyBag.CenterProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002C6 RID: 710 RVA: 0x000033A2 File Offset: 0x000015A2
			public CenterProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400015D RID: 349
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

			// Token: 0x0400015E RID: 350
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000096 RID: 150
		public class ExtentsProperty : Property<Bounds, Vector3>
		{
			// Token: 0x060002C7 RID: 711 RVA: 0x0000B86C File Offset: 0x00009A6C
			// Note: this type is marked as 'beforefieldinit'.
			static ExtentsProperty()
			{
				Il2CppClassPointerStore<BoundsPropertyBag.ExtentsProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BoundsPropertyBag>.NativeClassPtr, "ExtentsProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoundsPropertyBag.ExtentsProperty>.NativeClassPtr);
				BoundsPropertyBag.ExtentsProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsPropertyBag.ExtentsProperty>.NativeClassPtr, 100663511);
				BoundsPropertyBag.ExtentsProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsPropertyBag.ExtentsProperty>.NativeClassPtr, 100663512);
			}

			// Token: 0x1700009C RID: 156
			// (get) Token: 0x060002C8 RID: 712 RVA: 0x0000B8C0 File Offset: 0x00009AC0
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232410, XrefRangeEnd = 1232412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoundsPropertyBag.ExtentsProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060002C9 RID: 713 RVA: 0x0000B904 File Offset: 0x00009B04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232412, XrefRangeEnd = 1232415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ExtentsProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoundsPropertyBag.ExtentsProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsPropertyBag.ExtentsProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002CA RID: 714 RVA: 0x000033AB File Offset: 0x000015AB
			public ExtentsProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400015F RID: 351
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

			// Token: 0x04000160 RID: 352
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
