using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Unity.Properties.Internal
{
	// Token: 0x02000025 RID: 37
	public class ColorPropertyBag : ContainerPropertyBag<Color>
	{
		// Token: 0x0600014C RID: 332 RVA: 0x00002938 File Offset: 0x00000B38
		// Note: this type is marked as 'beforefieldinit'.
		static ColorPropertyBag()
		{
			Il2CppClassPointerStore<ColorPropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties.Internal", "ColorPropertyBag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorPropertyBag>.NativeClassPtr);
			ColorPropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorPropertyBag>.NativeClassPtr, 100663448);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00007340 File Offset: 0x00005540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232031, XrefRangeEnd = 1232070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorPropertyBag()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorPropertyBag>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorPropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002971 File Offset: 0x00000B71
		public ColorPropertyBag(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200007B RID: 123
		public class RProperty : Property<Color, float>
		{
			// Token: 0x0600025B RID: 603 RVA: 0x0000A210 File Offset: 0x00008410
			// Note: this type is marked as 'beforefieldinit'.
			static RProperty()
			{
				Il2CppClassPointerStore<ColorPropertyBag.RProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorPropertyBag>.NativeClassPtr, "RProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorPropertyBag.RProperty>.NativeClassPtr);
				ColorPropertyBag.RProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorPropertyBag.RProperty>.NativeClassPtr, 100663449);
				ColorPropertyBag.RProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorPropertyBag.RProperty>.NativeClassPtr, 100663450);
			}

			// Token: 0x17000081 RID: 129
			// (get) Token: 0x0600025C RID: 604 RVA: 0x0000A264 File Offset: 0x00008464
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232011, XrefRangeEnd = 1232013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorPropertyBag.RProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600025D RID: 605 RVA: 0x0000A2A8 File Offset: 0x000084A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232013, XrefRangeEnd = 1232016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorPropertyBag.RProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorPropertyBag.RProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600025E RID: 606 RVA: 0x000032B8 File Offset: 0x000014B8
			public RProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000129 RID: 297
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

			// Token: 0x0400012A RID: 298
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200007C RID: 124
		public class GProperty : Property<Color, float>
		{
			// Token: 0x0600025F RID: 607 RVA: 0x0000A2E4 File Offset: 0x000084E4
			// Note: this type is marked as 'beforefieldinit'.
			static GProperty()
			{
				Il2CppClassPointerStore<ColorPropertyBag.GProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorPropertyBag>.NativeClassPtr, "GProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorPropertyBag.GProperty>.NativeClassPtr);
				ColorPropertyBag.GProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorPropertyBag.GProperty>.NativeClassPtr, 100663451);
				ColorPropertyBag.GProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorPropertyBag.GProperty>.NativeClassPtr, 100663452);
			}

			// Token: 0x17000082 RID: 130
			// (get) Token: 0x06000260 RID: 608 RVA: 0x0000A338 File Offset: 0x00008538
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232016, XrefRangeEnd = 1232018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorPropertyBag.GProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000261 RID: 609 RVA: 0x0000A37C File Offset: 0x0000857C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232018, XrefRangeEnd = 1232021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorPropertyBag.GProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorPropertyBag.GProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000262 RID: 610 RVA: 0x000032C1 File Offset: 0x000014C1
			public GProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400012B RID: 299
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

			// Token: 0x0400012C RID: 300
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200007D RID: 125
		public class BProperty : Property<Color, float>
		{
			// Token: 0x06000263 RID: 611 RVA: 0x0000A3B8 File Offset: 0x000085B8
			// Note: this type is marked as 'beforefieldinit'.
			static BProperty()
			{
				Il2CppClassPointerStore<ColorPropertyBag.BProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorPropertyBag>.NativeClassPtr, "BProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorPropertyBag.BProperty>.NativeClassPtr);
				ColorPropertyBag.BProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorPropertyBag.BProperty>.NativeClassPtr, 100663453);
				ColorPropertyBag.BProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorPropertyBag.BProperty>.NativeClassPtr, 100663454);
			}

			// Token: 0x17000083 RID: 131
			// (get) Token: 0x06000264 RID: 612 RVA: 0x0000A40C File Offset: 0x0000860C
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232021, XrefRangeEnd = 1232023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorPropertyBag.BProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000265 RID: 613 RVA: 0x0000A450 File Offset: 0x00008650
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232023, XrefRangeEnd = 1232026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorPropertyBag.BProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorPropertyBag.BProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000266 RID: 614 RVA: 0x000032CA File Offset: 0x000014CA
			public BProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400012D RID: 301
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

			// Token: 0x0400012E RID: 302
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200007E RID: 126
		public class AProperty : Property<Color, float>
		{
			// Token: 0x06000267 RID: 615 RVA: 0x0000A48C File Offset: 0x0000868C
			// Note: this type is marked as 'beforefieldinit'.
			static AProperty()
			{
				Il2CppClassPointerStore<ColorPropertyBag.AProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorPropertyBag>.NativeClassPtr, "AProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorPropertyBag.AProperty>.NativeClassPtr);
				ColorPropertyBag.AProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorPropertyBag.AProperty>.NativeClassPtr, 100663455);
				ColorPropertyBag.AProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorPropertyBag.AProperty>.NativeClassPtr, 100663456);
			}

			// Token: 0x17000084 RID: 132
			// (get) Token: 0x06000268 RID: 616 RVA: 0x0000A4E0 File Offset: 0x000086E0
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232026, XrefRangeEnd = 1232028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ColorPropertyBag.AProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000269 RID: 617 RVA: 0x0000A524 File Offset: 0x00008724
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232028, XrefRangeEnd = 1232031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorPropertyBag.AProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorPropertyBag.AProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600026A RID: 618 RVA: 0x000032D3 File Offset: 0x000014D3
			public AProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400012F RID: 303
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

			// Token: 0x04000130 RID: 304
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
