using System;
using Canis.attributes;
using Canis.attributes.meta;
using dwd.core.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001B4 RID: 436
	public class LocalPlayerSumIntAttributes : MonoBehaviour
	{
		// Token: 0x06001347 RID: 4935 RVA: 0x00052954 File Offset: 0x00050B54
		// Note: this type is marked as 'beforefieldinit'.
		static LocalPlayerSumIntAttributes()
		{
			Il2CppClassPointerStore<LocalPlayerSumIntAttributes>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "LocalPlayerSumIntAttributes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalPlayerSumIntAttributes>.NativeClassPtr);
			LocalPlayerSumIntAttributes.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerSumIntAttributes>.NativeClassPtr, "attributes");
			LocalPlayerSumIntAttributes.NativeFieldInfoPtr_attributeContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerSumIntAttributes>.NativeClassPtr, "attributeContainer");
			LocalPlayerSumIntAttributes.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerSumIntAttributes>.NativeClassPtr, 100665927);
			LocalPlayerSumIntAttributes.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerSumIntAttributes>.NativeClassPtr, 100665928);
			LocalPlayerSumIntAttributes.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerSumIntAttributes>.NativeClassPtr, 100665929);
			LocalPlayerSumIntAttributes.NativeMethodInfoPtr_UpdateDisabled_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerSumIntAttributes>.NativeClassPtr, 100665930);
			LocalPlayerSumIntAttributes.NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerSumIntAttributes>.NativeClassPtr, 100665931);
			LocalPlayerSumIntAttributes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerSumIntAttributes>.NativeClassPtr, 100665932);
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x00052A24 File Offset: 0x00050C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712846, XrefRangeEnd = 712851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerSumIntAttributes.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x00052A64 File Offset: 0x00050C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712851, XrefRangeEnd = 712852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerSumIntAttributes.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x00052A98 File Offset: 0x00050C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerSumIntAttributes.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x00052ACC File Offset: 0x00050CCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 712868, RefRangeEnd = 712870, XrefRangeStart = 712852, XrefRangeEnd = 712868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerSumIntAttributes.NativeMethodInfoPtr_UpdateDisabled_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x00052B00 File Offset: 0x00050D00
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IHasAttributes GetAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerSumIntAttributes.NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHasAttributes>(intPtr3) : null;
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x00052B40 File Offset: 0x00050D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712870, XrefRangeEnd = 712875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalPlayerSumIntAttributes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalPlayerSumIntAttributes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerSumIntAttributes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x0000BF6A File Offset: 0x0000A16A
		public LocalPlayerSumIntAttributes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x0600134F RID: 4943 RVA: 0x00052B7C File Offset: 0x00050D7C
		// (set) Token: 0x06001350 RID: 4944 RVA: 0x0000BF73 File Offset: 0x0000A173
		public unsafe Il2CppStructArray<int> attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerSumIntAttributes.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerSumIntAttributes.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001351 RID: 4945 RVA: 0x00052BAC File Offset: 0x00050DAC
		// (set) Token: 0x06001352 RID: 4946 RVA: 0x0000BF92 File Offset: 0x0000A192
		public unsafe MetaAttributes attributeContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerSumIntAttributes.NativeFieldInfoPtr_attributeContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MetaAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerSumIntAttributes.NativeFieldInfoPtr_attributeContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B2A RID: 2858
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04000B2B RID: 2859
		private static readonly IntPtr NativeFieldInfoPtr_attributeContainer;

		// Token: 0x04000B2C RID: 2860
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x04000B2D RID: 2861
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000B2E RID: 2862
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000B2F RID: 2863
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDisabled_Private_Void_0;

		// Token: 0x04000B30 RID: 2864
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_IHasAttributes_0;

		// Token: 0x04000B31 RID: 2865
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003C6 RID: 966
		[ObfuscatedName("worm.match.components.LocalPlayerSumIntAttributes+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x0600270C RID: 9996 RVA: 0x0008E9B0 File Offset: 0x0008CBB0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LocalPlayerSumIntAttributes.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalPlayerSumIntAttributes>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalPlayerSumIntAttributes.__c>.NativeClassPtr);
				LocalPlayerSumIntAttributes.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerSumIntAttributes.__c>.NativeClassPtr, "<>9");
				LocalPlayerSumIntAttributes.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerSumIntAttributes.__c>.NativeClassPtr, "<>9__2_1");
				LocalPlayerSumIntAttributes.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerSumIntAttributes.__c>.NativeClassPtr, "<>9__2_0");
				LocalPlayerSumIntAttributes.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerSumIntAttributes.__c>.NativeClassPtr, 100665934);
				LocalPlayerSumIntAttributes.__c.NativeMethodInfoPtr__Start_b__2_1_Internal_Nullable_1_Int32_Nullable_1_Int32_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerSumIntAttributes.__c>.NativeClassPtr, 100665935);
				LocalPlayerSumIntAttributes.__c.NativeMethodInfoPtr__Start_b__2_0_Internal_Nullable_1_Int32_Nullable_1_Int32_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerSumIntAttributes.__c>.NativeClassPtr, 100665936);
			}

			// Token: 0x0600270D RID: 9997 RVA: 0x0008EA54 File Offset: 0x0008CC54
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalPlayerSumIntAttributes.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerSumIntAttributes.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600270E RID: 9998 RVA: 0x0008EA90 File Offset: 0x0008CC90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712806, XrefRangeEnd = 712810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Nullable<int> _Start_b__2_1(Nullable<int> a, Nullable<int> b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerSumIntAttributes.__c.NativeMethodInfoPtr__Start_b__2_1_Internal_Nullable_1_Int32_Nullable_1_Int32_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}

			// Token: 0x0600270F RID: 9999 RVA: 0x0008EAF4 File Offset: 0x0008CCF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712810, XrefRangeEnd = 712813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Nullable<int> _Start_b__2_0(Nullable<int> a, Nullable<bool> b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerSumIntAttributes.__c.NativeMethodInfoPtr__Start_b__2_0_Internal_Nullable_1_Int32_Nullable_1_Int32_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}

			// Token: 0x06002710 RID: 10000 RVA: 0x00015811 File Offset: 0x00013A11
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000ADD RID: 2781
			// (get) Token: 0x06002711 RID: 10001 RVA: 0x0008EB58 File Offset: 0x0008CD58
			// (set) Token: 0x06002712 RID: 10002 RVA: 0x0001581A File Offset: 0x00013A1A
			public unsafe static LocalPlayerSumIntAttributes.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LocalPlayerSumIntAttributes.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalPlayerSumIntAttributes.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LocalPlayerSumIntAttributes.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ADE RID: 2782
			// (get) Token: 0x06002713 RID: 10003 RVA: 0x0008EB80 File Offset: 0x0008CD80
			// (set) Token: 0x06002714 RID: 10004 RVA: 0x0001582C File Offset: 0x00013A2C
			public unsafe static Func<Nullable<int>, Nullable<int>, Nullable<int>> __9__2_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LocalPlayerSumIntAttributes.__c.NativeFieldInfoPtr___9__2_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Nullable<int>, Nullable<int>, Nullable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LocalPlayerSumIntAttributes.__c.NativeFieldInfoPtr___9__2_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ADF RID: 2783
			// (get) Token: 0x06002715 RID: 10005 RVA: 0x0008EBA8 File Offset: 0x0008CDA8
			// (set) Token: 0x06002716 RID: 10006 RVA: 0x0001583E File Offset: 0x00013A3E
			public unsafe static Func<Nullable<int>, Nullable<bool>, Nullable<int>> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LocalPlayerSumIntAttributes.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Nullable<int>, Nullable<bool>, Nullable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LocalPlayerSumIntAttributes.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400167C RID: 5756
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400167D RID: 5757
			private static readonly IntPtr NativeFieldInfoPtr___9__2_1;

			// Token: 0x0400167E RID: 5758
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x0400167F RID: 5759
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001680 RID: 5760
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__2_1_Internal_Nullable_1_Int32_Nullable_1_Int32_Nullable_1_Int32_0;

			// Token: 0x04001681 RID: 5761
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__2_0_Internal_Nullable_1_Int32_Nullable_1_Int32_Nullable_1_Boolean_0;
		}

		// Token: 0x020003C7 RID: 967
		[ObfuscatedName("worm.match.components.LocalPlayerSumIntAttributes+<Start>d__2")]
		public sealed class _Start_d__2 : global::Il2CppSystem.Object
		{
			// Token: 0x06002717 RID: 10007 RVA: 0x0008EBD0 File Offset: 0x0008CDD0
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__2()
			{
				Il2CppClassPointerStore<LocalPlayerSumIntAttributes._Start_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocalPlayerSumIntAttributes>.NativeClassPtr, "<Start>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalPlayerSumIntAttributes._Start_d__2>.NativeClassPtr);
				LocalPlayerSumIntAttributes._Start_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerSumIntAttributes._Start_d__2>.NativeClassPtr, "<>1__state");
				LocalPlayerSumIntAttributes._Start_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerSumIntAttributes._Start_d__2>.NativeClassPtr, "<>2__current");
				LocalPlayerSumIntAttributes._Start_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerSumIntAttributes._Start_d__2>.NativeClassPtr, "<>4__this");
				LocalPlayerSumIntAttributes._Start_d__2.NativeFieldInfoPtr__entitiesProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerSumIntAttributes._Start_d__2>.NativeClassPtr, "<entitiesProvider>5__2");
				LocalPlayerSumIntAttributes._Start_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerSumIntAttributes._Start_d__2>.NativeClassPtr, 100665937);
				LocalPlayerSumIntAttributes._Start_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerSumIntAttributes._Start_d__2>.NativeClassPtr, 100665938);
				LocalPlayerSumIntAttributes._Start_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerSumIntAttributes._Start_d__2>.NativeClassPtr, 100665939);
				LocalPlayerSumIntAttributes._Start_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerSumIntAttributes._Start_d__2>.NativeClassPtr, 100665940);
				LocalPlayerSumIntAttributes._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerSumIntAttributes._Start_d__2>.NativeClassPtr, 100665941);
				LocalPlayerSumIntAttributes._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerSumIntAttributes._Start_d__2>.NativeClassPtr, 100665942);
			}

			// Token: 0x06002718 RID: 10008 RVA: 0x0008ECC4 File Offset: 0x0008CEC4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalPlayerSumIntAttributes._Start_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerSumIntAttributes._Start_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002719 RID: 10009 RVA: 0x0008ED0C File Offset: 0x0008CF0C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerSumIntAttributes._Start_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600271A RID: 10010 RVA: 0x0008ED40 File Offset: 0x0008CF40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712813, XrefRangeEnd = 712841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerSumIntAttributes._Start_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000AE4 RID: 2788
			// (get) Token: 0x0600271B RID: 10011 RVA: 0x0008ED7C File Offset: 0x0008CF7C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerSumIntAttributes._Start_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600271C RID: 10012 RVA: 0x0008EDBC File Offset: 0x0008CFBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712841, XrefRangeEnd = 712846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerSumIntAttributes._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AE5 RID: 2789
			// (get) Token: 0x0600271D RID: 10013 RVA: 0x0008EDF0 File Offset: 0x0008CFF0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerSumIntAttributes._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600271E RID: 10014 RVA: 0x00015850 File Offset: 0x00013A50
			public _Start_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AE0 RID: 2784
			// (get) Token: 0x0600271F RID: 10015 RVA: 0x0008EE30 File Offset: 0x0008D030
			// (set) Token: 0x06002720 RID: 10016 RVA: 0x00015859 File Offset: 0x00013A59
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerSumIntAttributes._Start_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerSumIntAttributes._Start_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AE1 RID: 2785
			// (get) Token: 0x06002721 RID: 10017 RVA: 0x0008EE58 File Offset: 0x0008D058
			// (set) Token: 0x06002722 RID: 10018 RVA: 0x00015874 File Offset: 0x00013A74
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerSumIntAttributes._Start_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerSumIntAttributes._Start_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AE2 RID: 2786
			// (get) Token: 0x06002723 RID: 10019 RVA: 0x0008EE88 File Offset: 0x0008D088
			// (set) Token: 0x06002724 RID: 10020 RVA: 0x00015893 File Offset: 0x00013A93
			public unsafe LocalPlayerSumIntAttributes __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerSumIntAttributes._Start_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalPlayerSumIntAttributes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerSumIntAttributes._Start_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AE3 RID: 2787
			// (get) Token: 0x06002725 RID: 10021 RVA: 0x0008EEB8 File Offset: 0x0008D0B8
			// (set) Token: 0x06002726 RID: 10022 RVA: 0x000158B2 File Offset: 0x00013AB2
			public unsafe EntitiesProvider _entitiesProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerSumIntAttributes._Start_d__2.NativeFieldInfoPtr__entitiesProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerSumIntAttributes._Start_d__2.NativeFieldInfoPtr__entitiesProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001682 RID: 5762
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001683 RID: 5763
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001684 RID: 5764
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001685 RID: 5765
			private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__2;

			// Token: 0x04001686 RID: 5766
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001687 RID: 5767
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001688 RID: 5768
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001689 RID: 5769
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400168A RID: 5770
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400168B RID: 5771
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
