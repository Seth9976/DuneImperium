using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Unity.Properties.Internal
{
	// Token: 0x02000029 RID: 41
	public class Vector2IntPropertyBag : ContainerPropertyBag<Vector2Int>
	{
		// Token: 0x06000158 RID: 344 RVA: 0x00002A40 File Offset: 0x00000C40
		// Note: this type is marked as 'beforefieldinit'.
		static Vector2IntPropertyBag()
		{
			Il2CppClassPointerStore<Vector2IntPropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties.Internal", "Vector2IntPropertyBag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector2IntPropertyBag>.NativeClassPtr);
			Vector2IntPropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2IntPropertyBag>.NativeClassPtr, 100663478);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00007430 File Offset: 0x00005630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232218, XrefRangeEnd = 1232241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2IntPropertyBag()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector2IntPropertyBag>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2IntPropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002A79 File Offset: 0x00000C79
		public Vector2IntPropertyBag(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000088 RID: 136
		public class XProperty : Property<Vector2Int, int>
		{
			// Token: 0x0600028F RID: 655 RVA: 0x0000ACD4 File Offset: 0x00008ED4
			// Note: this type is marked as 'beforefieldinit'.
			static XProperty()
			{
				Il2CppClassPointerStore<Vector2IntPropertyBag.XProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Vector2IntPropertyBag>.NativeClassPtr, "XProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector2IntPropertyBag.XProperty>.NativeClassPtr);
				Vector2IntPropertyBag.XProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2IntPropertyBag.XProperty>.NativeClassPtr, 100663479);
				Vector2IntPropertyBag.XProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2IntPropertyBag.XProperty>.NativeClassPtr, 100663480);
			}

			// Token: 0x1700008E RID: 142
			// (get) Token: 0x06000290 RID: 656 RVA: 0x0000AD28 File Offset: 0x00008F28
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232208, XrefRangeEnd = 1232210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector2IntPropertyBag.XProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000291 RID: 657 RVA: 0x0000AD6C File Offset: 0x00008F6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232210, XrefRangeEnd = 1232213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector2IntPropertyBag.XProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2IntPropertyBag.XProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000292 RID: 658 RVA: 0x0000332D File Offset: 0x0000152D
			public XProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000143 RID: 323
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

			// Token: 0x04000144 RID: 324
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000089 RID: 137
		public class YProperty : Property<Vector2Int, int>
		{
			// Token: 0x06000293 RID: 659 RVA: 0x0000ADA8 File Offset: 0x00008FA8
			// Note: this type is marked as 'beforefieldinit'.
			static YProperty()
			{
				Il2CppClassPointerStore<Vector2IntPropertyBag.YProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Vector2IntPropertyBag>.NativeClassPtr, "YProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector2IntPropertyBag.YProperty>.NativeClassPtr);
				Vector2IntPropertyBag.YProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2IntPropertyBag.YProperty>.NativeClassPtr, 100663481);
				Vector2IntPropertyBag.YProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2IntPropertyBag.YProperty>.NativeClassPtr, 100663482);
			}

			// Token: 0x1700008F RID: 143
			// (get) Token: 0x06000294 RID: 660 RVA: 0x0000ADFC File Offset: 0x00008FFC
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232213, XrefRangeEnd = 1232215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vector2IntPropertyBag.YProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000295 RID: 661 RVA: 0x0000AE40 File Offset: 0x00009040
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232215, XrefRangeEnd = 1232218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe YProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vector2IntPropertyBag.YProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2IntPropertyBag.YProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000296 RID: 662 RVA: 0x00003336 File Offset: 0x00001536
			public YProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000145 RID: 325
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

			// Token: 0x04000146 RID: 326
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
