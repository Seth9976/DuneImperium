using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.UI;
using voodoo;

namespace worm.match.dataRenderers
{
	// Token: 0x02000155 RID: 341
	public class WormPromptSourceImageRenderer : VersionedDataComponentObserver<EntityComponent>
	{
		// Token: 0x06000F42 RID: 3906 RVA: 0x00045F30 File Offset: 0x00044130
		// Note: this type is marked as 'beforefieldinit'.
		static WormPromptSourceImageRenderer()
		{
			Il2CppClassPointerStore<WormPromptSourceImageRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormPromptSourceImageRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPromptSourceImageRenderer>.NativeClassPtr);
			WormPromptSourceImageRenderer.NativeFieldInfoPtr_assetPathFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPromptSourceImageRenderer>.NativeClassPtr, "assetPathFormat");
			WormPromptSourceImageRenderer.NativeFieldInfoPtr_atlasName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPromptSourceImageRenderer>.NativeClassPtr, "atlasName");
			WormPromptSourceImageRenderer.NativeFieldInfoPtr_frameAssetPathFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPromptSourceImageRenderer>.NativeClassPtr, "frameAssetPathFormat");
			WormPromptSourceImageRenderer.NativeFieldInfoPtr_frameAtlasName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPromptSourceImageRenderer>.NativeClassPtr, "frameAtlasName");
			WormPromptSourceImageRenderer.NativeFieldInfoPtr_frameImageObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPromptSourceImageRenderer>.NativeClassPtr, "frameImageObject");
			WormPromptSourceImageRenderer.NativeFieldInfoPtr_fixedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPromptSourceImageRenderer>.NativeClassPtr, "fixedTypes");
			WormPromptSourceImageRenderer.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPromptSourceImageRenderer>.NativeClassPtr, "image");
			WormPromptSourceImageRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPromptSourceImageRenderer>.NativeClassPtr, 100665360);
			WormPromptSourceImageRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPromptSourceImageRenderer>.NativeClassPtr, 100665361);
			WormPromptSourceImageRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPromptSourceImageRenderer>.NativeClassPtr, 100665362);
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x00046028 File Offset: 0x00044228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707597, XrefRangeEnd = 707602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPromptSourceImageRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x00046064 File Offset: 0x00044264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707602, XrefRangeEnd = 707666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPromptSourceImageRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x000460A0 File Offset: 0x000442A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707666, XrefRangeEnd = 707682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPromptSourceImageRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPromptSourceImageRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPromptSourceImageRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x0000A0A3 File Offset: 0x000082A3
		public WormPromptSourceImageRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000F47 RID: 3911 RVA: 0x000460DC File Offset: 0x000442DC
		// (set) Token: 0x06000F48 RID: 3912 RVA: 0x0000A0AC File Offset: 0x000082AC
		public unsafe string assetPathFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptSourceImageRenderer.NativeFieldInfoPtr_assetPathFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptSourceImageRenderer.NativeFieldInfoPtr_assetPathFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000F49 RID: 3913 RVA: 0x00046104 File Offset: 0x00044304
		// (set) Token: 0x06000F4A RID: 3914 RVA: 0x0000A0CB File Offset: 0x000082CB
		public unsafe string atlasName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptSourceImageRenderer.NativeFieldInfoPtr_atlasName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptSourceImageRenderer.NativeFieldInfoPtr_atlasName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000F4B RID: 3915 RVA: 0x0004612C File Offset: 0x0004432C
		// (set) Token: 0x06000F4C RID: 3916 RVA: 0x0000A0EA File Offset: 0x000082EA
		public unsafe string frameAssetPathFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptSourceImageRenderer.NativeFieldInfoPtr_frameAssetPathFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptSourceImageRenderer.NativeFieldInfoPtr_frameAssetPathFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000F4D RID: 3917 RVA: 0x00046154 File Offset: 0x00044354
		// (set) Token: 0x06000F4E RID: 3918 RVA: 0x0000A109 File Offset: 0x00008309
		public unsafe string frameAtlasName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptSourceImageRenderer.NativeFieldInfoPtr_frameAtlasName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptSourceImageRenderer.NativeFieldInfoPtr_frameAtlasName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000F4F RID: 3919 RVA: 0x0004617C File Offset: 0x0004437C
		// (set) Token: 0x06000F50 RID: 3920 RVA: 0x0000A128 File Offset: 0x00008328
		public unsafe Image frameImageObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptSourceImageRenderer.NativeFieldInfoPtr_frameImageObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptSourceImageRenderer.NativeFieldInfoPtr_frameImageObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000F51 RID: 3921 RVA: 0x000461AC File Offset: 0x000443AC
		// (set) Token: 0x06000F52 RID: 3922 RVA: 0x0000A147 File Offset: 0x00008347
		public unsafe Il2CppReferenceArray<WormPromptSourceImageRenderer.FixedCardTypeData> fixedTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptSourceImageRenderer.NativeFieldInfoPtr_fixedTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WormPromptSourceImageRenderer.FixedCardTypeData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptSourceImageRenderer.NativeFieldInfoPtr_fixedTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000F53 RID: 3923 RVA: 0x000461DC File Offset: 0x000443DC
		// (set) Token: 0x06000F54 RID: 3924 RVA: 0x0000A166 File Offset: 0x00008366
		public unsafe Image image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptSourceImageRenderer.NativeFieldInfoPtr_image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptSourceImageRenderer.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008C8 RID: 2248
		private static readonly IntPtr NativeFieldInfoPtr_assetPathFormat;

		// Token: 0x040008C9 RID: 2249
		private static readonly IntPtr NativeFieldInfoPtr_atlasName;

		// Token: 0x040008CA RID: 2250
		private static readonly IntPtr NativeFieldInfoPtr_frameAssetPathFormat;

		// Token: 0x040008CB RID: 2251
		private static readonly IntPtr NativeFieldInfoPtr_frameAtlasName;

		// Token: 0x040008CC RID: 2252
		private static readonly IntPtr NativeFieldInfoPtr_frameImageObject;

		// Token: 0x040008CD RID: 2253
		private static readonly IntPtr NativeFieldInfoPtr_fixedTypes;

		// Token: 0x040008CE RID: 2254
		private static readonly IntPtr NativeFieldInfoPtr_image;

		// Token: 0x040008CF RID: 2255
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040008D0 RID: 2256
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x040008D1 RID: 2257
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200039D RID: 925
		[Serializable]
		public class FixedCardTypeData : Object
		{
			// Token: 0x0600253D RID: 9533 RVA: 0x00088A10 File Offset: 0x00086C10
			// Note: this type is marked as 'beforefieldinit'.
			static FixedCardTypeData()
			{
				Il2CppClassPointerStore<WormPromptSourceImageRenderer.FixedCardTypeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPromptSourceImageRenderer>.NativeClassPtr, "FixedCardTypeData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPromptSourceImageRenderer.FixedCardTypeData>.NativeClassPtr);
				WormPromptSourceImageRenderer.FixedCardTypeData.NativeFieldInfoPtr_entityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPromptSourceImageRenderer.FixedCardTypeData>.NativeClassPtr, "entityName");
				WormPromptSourceImageRenderer.FixedCardTypeData.NativeFieldInfoPtr_imageName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPromptSourceImageRenderer.FixedCardTypeData>.NativeClassPtr, "imageName");
				WormPromptSourceImageRenderer.FixedCardTypeData.NativeFieldInfoPtr_frameName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPromptSourceImageRenderer.FixedCardTypeData>.NativeClassPtr, "frameName");
				WormPromptSourceImageRenderer.FixedCardTypeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPromptSourceImageRenderer.FixedCardTypeData>.NativeClassPtr, 100665363);
			}

			// Token: 0x0600253E RID: 9534 RVA: 0x00088A8C File Offset: 0x00086C8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707589, XrefRangeEnd = 707597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FixedCardTypeData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPromptSourceImageRenderer.FixedCardTypeData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPromptSourceImageRenderer.FixedCardTypeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600253F RID: 9535 RVA: 0x00014BE2 File Offset: 0x00012DE2
			public FixedCardTypeData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A5D RID: 2653
			// (get) Token: 0x06002540 RID: 9536 RVA: 0x00088AC8 File Offset: 0x00086CC8
			// (set) Token: 0x06002541 RID: 9537 RVA: 0x00014BEB File Offset: 0x00012DEB
			public unsafe string entityName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptSourceImageRenderer.FixedCardTypeData.NativeFieldInfoPtr_entityName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptSourceImageRenderer.FixedCardTypeData.NativeFieldInfoPtr_entityName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000A5E RID: 2654
			// (get) Token: 0x06002542 RID: 9538 RVA: 0x00088AF0 File Offset: 0x00086CF0
			// (set) Token: 0x06002543 RID: 9539 RVA: 0x00014C0A File Offset: 0x00012E0A
			public unsafe string imageName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptSourceImageRenderer.FixedCardTypeData.NativeFieldInfoPtr_imageName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptSourceImageRenderer.FixedCardTypeData.NativeFieldInfoPtr_imageName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000A5F RID: 2655
			// (get) Token: 0x06002544 RID: 9540 RVA: 0x00088B18 File Offset: 0x00086D18
			// (set) Token: 0x06002545 RID: 9541 RVA: 0x00014C29 File Offset: 0x00012E29
			public unsafe string frameName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptSourceImageRenderer.FixedCardTypeData.NativeFieldInfoPtr_frameName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptSourceImageRenderer.FixedCardTypeData.NativeFieldInfoPtr_frameName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001560 RID: 5472
			private static readonly IntPtr NativeFieldInfoPtr_entityName;

			// Token: 0x04001561 RID: 5473
			private static readonly IntPtr NativeFieldInfoPtr_imageName;

			// Token: 0x04001562 RID: 5474
			private static readonly IntPtr NativeFieldInfoPtr_frameName;

			// Token: 0x04001563 RID: 5475
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200039E RID: 926
		[ObfuscatedName("worm.match.dataRenderers.WormPromptSourceImageRenderer+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x06002546 RID: 9542 RVA: 0x00088B40 File Offset: 0x00086D40
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<WormPromptSourceImageRenderer.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPromptSourceImageRenderer>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPromptSourceImageRenderer.__c__DisplayClass9_0>.NativeClassPtr);
				WormPromptSourceImageRenderer.__c__DisplayClass9_0.NativeFieldInfoPtr_entityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPromptSourceImageRenderer.__c__DisplayClass9_0>.NativeClassPtr, "entityName");
				WormPromptSourceImageRenderer.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPromptSourceImageRenderer.__c__DisplayClass9_0>.NativeClassPtr, 100665364);
				WormPromptSourceImageRenderer.__c__DisplayClass9_0.NativeMethodInfoPtr__versionChanged_b__0_Internal_Boolean_FixedCardTypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPromptSourceImageRenderer.__c__DisplayClass9_0>.NativeClassPtr, 100665365);
			}

			// Token: 0x06002547 RID: 9543 RVA: 0x00088BA8 File Offset: 0x00086DA8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPromptSourceImageRenderer.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPromptSourceImageRenderer.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002548 RID: 9544 RVA: 0x00088BE4 File Offset: 0x00086DE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _versionChanged_b__0(WormPromptSourceImageRenderer.FixedCardTypeData d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPromptSourceImageRenderer.__c__DisplayClass9_0.NativeMethodInfoPtr__versionChanged_b__0_Internal_Boolean_FixedCardTypeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002549 RID: 9545 RVA: 0x00014C48 File Offset: 0x00012E48
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A60 RID: 2656
			// (get) Token: 0x0600254A RID: 9546 RVA: 0x00088C34 File Offset: 0x00086E34
			// (set) Token: 0x0600254B RID: 9547 RVA: 0x00014C51 File Offset: 0x00012E51
			public unsafe string entityName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptSourceImageRenderer.__c__DisplayClass9_0.NativeFieldInfoPtr_entityName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPromptSourceImageRenderer.__c__DisplayClass9_0.NativeFieldInfoPtr_entityName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001564 RID: 5476
			private static readonly IntPtr NativeFieldInfoPtr_entityName;

			// Token: 0x04001565 RID: 5477
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001566 RID: 5478
			private static readonly IntPtr NativeMethodInfoPtr__versionChanged_b__0_Internal_Boolean_FixedCardTypeData_0;
		}
	}
}
