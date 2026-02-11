using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using voodoo;
using worm.canis.data.enums;
using worm.match.data;

namespace worm.match.components
{
	// Token: 0x020001AB RID: 427
	public class AllianceTokenTooltipSource : VersionedDataComponentObserver<WormFactionData>
	{
		// Token: 0x060012E6 RID: 4838 RVA: 0x00051824 File Offset: 0x0004FA24
		// Note: this type is marked as 'beforefieldinit'.
		static AllianceTokenTooltipSource()
		{
			Il2CppClassPointerStore<AllianceTokenTooltipSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "AllianceTokenTooltipSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllianceTokenTooltipSource>.NativeClassPtr);
			AllianceTokenTooltipSource.NativeFieldInfoPtr_faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllianceTokenTooltipSource>.NativeClassPtr, "faction");
			AllianceTokenTooltipSource.NativeFieldInfoPtr_factionKeyPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllianceTokenTooltipSource>.NativeClassPtr, "factionKeyPairs");
			AllianceTokenTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllianceTokenTooltipSource>.NativeClassPtr, 100665878);
			AllianceTokenTooltipSource.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllianceTokenTooltipSource>.NativeClassPtr, 100665879);
			AllianceTokenTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllianceTokenTooltipSource>.NativeClassPtr, 100665880);
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x000518B8 File Offset: 0x0004FAB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712527, XrefRangeEnd = 712543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLocalizedTooltip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllianceTokenTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x000518F0 File Offset: 0x0004FAF0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AllianceTokenTooltipSource.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x0005192C File Offset: 0x0004FB2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712543, XrefRangeEnd = 712553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AllianceTokenTooltipSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AllianceTokenTooltipSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllianceTokenTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x0000BC3F File Offset: 0x00009E3F
		public AllianceTokenTooltipSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x060012EB RID: 4843 RVA: 0x00051968 File Offset: 0x0004FB68
		// (set) Token: 0x060012EC RID: 4844 RVA: 0x0000BC48 File Offset: 0x00009E48
		public unsafe Factions faction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllianceTokenTooltipSource.NativeFieldInfoPtr_faction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllianceTokenTooltipSource.NativeFieldInfoPtr_faction)) = value;
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x060012ED RID: 4845 RVA: 0x00051990 File Offset: 0x0004FB90
		// (set) Token: 0x060012EE RID: 4846 RVA: 0x0000BC63 File Offset: 0x00009E63
		public unsafe List<AllianceTokenTooltipSource.FactionKeyPair> factionKeyPairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllianceTokenTooltipSource.NativeFieldInfoPtr_factionKeyPairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AllianceTokenTooltipSource.FactionKeyPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllianceTokenTooltipSource.NativeFieldInfoPtr_factionKeyPairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AF4 RID: 2804
		private static readonly IntPtr NativeFieldInfoPtr_faction;

		// Token: 0x04000AF5 RID: 2805
		private static readonly IntPtr NativeFieldInfoPtr_factionKeyPairs;

		// Token: 0x04000AF6 RID: 2806
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0;

		// Token: 0x04000AF7 RID: 2807
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x04000AF8 RID: 2808
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003C1 RID: 961
		[Serializable]
		public class FactionKeyPair : Object
		{
			// Token: 0x060026D2 RID: 9938 RVA: 0x0008DF44 File Offset: 0x0008C144
			// Note: this type is marked as 'beforefieldinit'.
			static FactionKeyPair()
			{
				Il2CppClassPointerStore<AllianceTokenTooltipSource.FactionKeyPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AllianceTokenTooltipSource>.NativeClassPtr, "FactionKeyPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllianceTokenTooltipSource.FactionKeyPair>.NativeClassPtr);
				AllianceTokenTooltipSource.FactionKeyPair.NativeFieldInfoPtr_Faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllianceTokenTooltipSource.FactionKeyPair>.NativeClassPtr, "Faction");
				AllianceTokenTooltipSource.FactionKeyPair.NativeFieldInfoPtr_LocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllianceTokenTooltipSource.FactionKeyPair>.NativeClassPtr, "LocKey");
				AllianceTokenTooltipSource.FactionKeyPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllianceTokenTooltipSource.FactionKeyPair>.NativeClassPtr, 100665881);
			}

			// Token: 0x060026D3 RID: 9939 RVA: 0x0008DFAC File Offset: 0x0008C1AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712523, XrefRangeEnd = 712527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FactionKeyPair()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AllianceTokenTooltipSource.FactionKeyPair>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllianceTokenTooltipSource.FactionKeyPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060026D4 RID: 9940 RVA: 0x00015660 File Offset: 0x00013860
			public FactionKeyPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000ACA RID: 2762
			// (get) Token: 0x060026D5 RID: 9941 RVA: 0x0008DFE8 File Offset: 0x0008C1E8
			// (set) Token: 0x060026D6 RID: 9942 RVA: 0x00015669 File Offset: 0x00013869
			public unsafe Factions Faction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllianceTokenTooltipSource.FactionKeyPair.NativeFieldInfoPtr_Faction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllianceTokenTooltipSource.FactionKeyPair.NativeFieldInfoPtr_Faction)) = value;
				}
			}

			// Token: 0x17000ACB RID: 2763
			// (get) Token: 0x060026D7 RID: 9943 RVA: 0x0008E010 File Offset: 0x0008C210
			// (set) Token: 0x060026D8 RID: 9944 RVA: 0x00015684 File Offset: 0x00013884
			public unsafe string LocKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllianceTokenTooltipSource.FactionKeyPair.NativeFieldInfoPtr_LocKey);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllianceTokenTooltipSource.FactionKeyPair.NativeFieldInfoPtr_LocKey), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400165B RID: 5723
			private static readonly IntPtr NativeFieldInfoPtr_Faction;

			// Token: 0x0400165C RID: 5724
			private static readonly IntPtr NativeFieldInfoPtr_LocKey;

			// Token: 0x0400165D RID: 5725
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
