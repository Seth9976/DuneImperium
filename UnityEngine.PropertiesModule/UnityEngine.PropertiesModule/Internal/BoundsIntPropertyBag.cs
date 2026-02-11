using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Unity.Properties.Internal
{
	// Token: 0x0200002E RID: 46
	public class BoundsIntPropertyBag : ContainerPropertyBag<BoundsInt>
	{
		// Token: 0x06000167 RID: 359 RVA: 0x00002B8A File Offset: 0x00000D8A
		// Note: this type is marked as 'beforefieldinit'.
		static BoundsIntPropertyBag()
		{
			Il2CppClassPointerStore<BoundsIntPropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties.Internal", "BoundsIntPropertyBag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoundsIntPropertyBag>.NativeClassPtr);
			BoundsIntPropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsIntPropertyBag>.NativeClassPtr, 100663513);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000755C File Offset: 0x0000575C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232448, XrefRangeEnd = 1232471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoundsIntPropertyBag()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoundsIntPropertyBag>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsIntPropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002BC3 File Offset: 0x00000DC3
		public BoundsIntPropertyBag(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000097 RID: 151
		public class PositionProperty : Property<BoundsInt, Vector3Int>
		{
			// Token: 0x060002CB RID: 715 RVA: 0x0000B940 File Offset: 0x00009B40
			// Note: this type is marked as 'beforefieldinit'.
			static PositionProperty()
			{
				Il2CppClassPointerStore<BoundsIntPropertyBag.PositionProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BoundsIntPropertyBag>.NativeClassPtr, "PositionProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoundsIntPropertyBag.PositionProperty>.NativeClassPtr);
				BoundsIntPropertyBag.PositionProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsIntPropertyBag.PositionProperty>.NativeClassPtr, 100663514);
				BoundsIntPropertyBag.PositionProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsIntPropertyBag.PositionProperty>.NativeClassPtr, 100663515);
			}

			// Token: 0x1700009D RID: 157
			// (get) Token: 0x060002CC RID: 716 RVA: 0x0000B994 File Offset: 0x00009B94
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232438, XrefRangeEnd = 1232440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoundsIntPropertyBag.PositionProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060002CD RID: 717 RVA: 0x0000B9D8 File Offset: 0x00009BD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232440, XrefRangeEnd = 1232443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PositionProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoundsIntPropertyBag.PositionProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsIntPropertyBag.PositionProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002CE RID: 718 RVA: 0x000033B4 File Offset: 0x000015B4
			public PositionProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000161 RID: 353
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

			// Token: 0x04000162 RID: 354
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000098 RID: 152
		public class SizeProperty : Property<BoundsInt, Vector3Int>
		{
			// Token: 0x060002CF RID: 719 RVA: 0x0000BA14 File Offset: 0x00009C14
			// Note: this type is marked as 'beforefieldinit'.
			static SizeProperty()
			{
				Il2CppClassPointerStore<BoundsIntPropertyBag.SizeProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BoundsIntPropertyBag>.NativeClassPtr, "SizeProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoundsIntPropertyBag.SizeProperty>.NativeClassPtr);
				BoundsIntPropertyBag.SizeProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsIntPropertyBag.SizeProperty>.NativeClassPtr, 100663516);
				BoundsIntPropertyBag.SizeProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsIntPropertyBag.SizeProperty>.NativeClassPtr, 100663517);
			}

			// Token: 0x1700009E RID: 158
			// (get) Token: 0x060002D0 RID: 720 RVA: 0x0000BA68 File Offset: 0x00009C68
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232443, XrefRangeEnd = 1232445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoundsIntPropertyBag.SizeProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060002D1 RID: 721 RVA: 0x0000BAAC File Offset: 0x00009CAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232445, XrefRangeEnd = 1232448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SizeProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoundsIntPropertyBag.SizeProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsIntPropertyBag.SizeProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002D2 RID: 722 RVA: 0x000033BD File Offset: 0x000015BD
			public SizeProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000163 RID: 355
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

			// Token: 0x04000164 RID: 356
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
