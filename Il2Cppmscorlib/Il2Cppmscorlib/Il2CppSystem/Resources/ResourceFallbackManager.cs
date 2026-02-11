using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Resources
{
	// Token: 0x020003E6 RID: 998
	public class ResourceFallbackManager : Object
	{
		// Token: 0x06003A73 RID: 14963 RVA: 0x00119B70 File Offset: 0x00117D70
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceFallbackManager()
		{
			Il2CppClassPointerStore<ResourceFallbackManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "ResourceFallbackManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceFallbackManager>.NativeClassPtr);
			ResourceFallbackManager.NativeFieldInfoPtr_m_startingCulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceFallbackManager>.NativeClassPtr, "m_startingCulture");
			ResourceFallbackManager.NativeFieldInfoPtr_m_neutralResourcesCulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceFallbackManager>.NativeClassPtr, "m_neutralResourcesCulture");
			ResourceFallbackManager.NativeFieldInfoPtr_m_useParents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceFallbackManager>.NativeClassPtr, "m_useParents");
			ResourceFallbackManager.NativeMethodInfoPtr__ctor_Internal_Void_CultureInfo_CultureInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceFallbackManager>.NativeClassPtr, 100672024);
			ResourceFallbackManager.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceFallbackManager>.NativeClassPtr, 100672025);
			ResourceFallbackManager.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceFallbackManager>.NativeClassPtr, 100672026);
		}

		// Token: 0x06003A74 RID: 14964 RVA: 0x00119C18 File Offset: 0x00117E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1396479, XrefRangeEnd = 1396487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceFallbackManager(CultureInfo startingCulture, CultureInfo neutralResourcesCulture, bool useParents)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceFallbackManager>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(startingCulture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(neutralResourcesCulture);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useParents;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceFallbackManager.NativeMethodInfoPtr__ctor_Internal_Void_CultureInfo_CultureInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A75 RID: 14965 RVA: 0x00119C84 File Offset: 0x00117E84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1396492, RefRangeEnd = 1396494, XrefRangeStart = 1396487, XrefRangeEnd = 1396492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceFallbackManager.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003A76 RID: 14966 RVA: 0x00119CC4 File Offset: 0x00117EC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1396492, RefRangeEnd = 1396494, XrefRangeStart = 1396492, XrefRangeEnd = 1396494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<CultureInfo> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceFallbackManager.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<CultureInfo>>(intPtr3) : null;
		}

		// Token: 0x06003A77 RID: 14967 RVA: 0x00015B40 File Offset: 0x00013D40
		public ResourceFallbackManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x06003A78 RID: 14968 RVA: 0x00119D04 File Offset: 0x00117F04
		// (set) Token: 0x06003A79 RID: 14969 RVA: 0x00015B49 File Offset: 0x00013D49
		public unsafe CultureInfo m_startingCulture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager.NativeFieldInfoPtr_m_startingCulture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager.NativeFieldInfoPtr_m_startingCulture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x06003A7A RID: 14970 RVA: 0x00119D34 File Offset: 0x00117F34
		// (set) Token: 0x06003A7B RID: 14971 RVA: 0x00015B68 File Offset: 0x00013D68
		public unsafe CultureInfo m_neutralResourcesCulture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager.NativeFieldInfoPtr_m_neutralResourcesCulture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager.NativeFieldInfoPtr_m_neutralResourcesCulture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x06003A7C RID: 14972 RVA: 0x00119D64 File Offset: 0x00117F64
		// (set) Token: 0x06003A7D RID: 14973 RVA: 0x00015B87 File Offset: 0x00013D87
		public unsafe bool m_useParents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager.NativeFieldInfoPtr_m_useParents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager.NativeFieldInfoPtr_m_useParents)) = value;
			}
		}

		// Token: 0x04002F4D RID: 12109
		private static readonly IntPtr NativeFieldInfoPtr_m_startingCulture;

		// Token: 0x04002F4E RID: 12110
		private static readonly IntPtr NativeFieldInfoPtr_m_neutralResourcesCulture;

		// Token: 0x04002F4F RID: 12111
		private static readonly IntPtr NativeFieldInfoPtr_m_useParents;

		// Token: 0x04002F50 RID: 12112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CultureInfo_CultureInfo_Boolean_0;

		// Token: 0x04002F51 RID: 12113
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04002F52 RID: 12114
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_CultureInfo_0;

		// Token: 0x020006B4 RID: 1716
		[ObfuscatedName("System.Resources.ResourceFallbackManager+<GetEnumerator>d__5")]
		public sealed class _GetEnumerator_d__5 : Object
		{
			// Token: 0x06005C55 RID: 23637 RVA: 0x001A3224 File Offset: 0x001A1424
			// Note: this type is marked as 'beforefieldinit'.
			static _GetEnumerator_d__5()
			{
				Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResourceFallbackManager>.NativeClassPtr, "<GetEnumerator>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr);
				ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr, "<>1__state");
				ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr, "<>2__current");
				ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr, "<>4__this");
				ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr__reachedNeutralResourcesCulture_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr, "<reachedNeutralResourcesCulture>5__2");
				ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr__currentCulture_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr, "<currentCulture>5__3");
				ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr, 100672027);
				ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr, 100672028);
				ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr, 100672029);
				ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Globalization_CultureInfo__get_Current_Private_Virtual_Final_New_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr, 100672030);
				ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr, 100672031);
				ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr, 100672032);
			}

			// Token: 0x06005C56 RID: 23638 RVA: 0x001A332C File Offset: 0x001A152C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetEnumerator_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceFallbackManager._GetEnumerator_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005C57 RID: 23639 RVA: 0x001A3374 File Offset: 0x001A1574
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005C58 RID: 23640 RVA: 0x001A33A8 File Offset: 0x001A15A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1396473, XrefRangeEnd = 1396474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700179D RID: 6045
			// (get) Token: 0x06005C59 RID: 23641 RVA: 0x001A33E4 File Offset: 0x001A15E4
			public unsafe CultureInfo System.Collections.Generic.IEnumerator<System.Globalization.CultureInfo>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Globalization_CultureInfo__get_Current_Private_Virtual_Final_New_get_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
				}
			}

			// Token: 0x06005C5A RID: 23642 RVA: 0x001A3424 File Offset: 0x001A1624
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1396474, XrefRangeEnd = 1396479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700179E RID: 6046
			// (get) Token: 0x06005C5B RID: 23643 RVA: 0x001A3458 File Offset: 0x001A1658
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceFallbackManager._GetEnumerator_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005C5C RID: 23644 RVA: 0x000217A7 File Offset: 0x0001F9A7
			public _GetEnumerator_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001798 RID: 6040
			// (get) Token: 0x06005C5D RID: 23645 RVA: 0x001A3498 File Offset: 0x001A1698
			// (set) Token: 0x06005C5E RID: 23646 RVA: 0x000217B0 File Offset: 0x0001F9B0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001799 RID: 6041
			// (get) Token: 0x06005C5F RID: 23647 RVA: 0x001A34C0 File Offset: 0x001A16C0
			// (set) Token: 0x06005C60 RID: 23648 RVA: 0x000217CB File Offset: 0x0001F9CB
			public unsafe CultureInfo __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700179A RID: 6042
			// (get) Token: 0x06005C61 RID: 23649 RVA: 0x001A34F0 File Offset: 0x001A16F0
			// (set) Token: 0x06005C62 RID: 23650 RVA: 0x000217EA File Offset: 0x0001F9EA
			public unsafe ResourceFallbackManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceFallbackManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700179B RID: 6043
			// (get) Token: 0x06005C63 RID: 23651 RVA: 0x001A3520 File Offset: 0x001A1720
			// (set) Token: 0x06005C64 RID: 23652 RVA: 0x00021809 File Offset: 0x0001FA09
			public unsafe bool _reachedNeutralResourcesCulture_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr__reachedNeutralResourcesCulture_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr__reachedNeutralResourcesCulture_5__2)) = value;
				}
			}

			// Token: 0x1700179C RID: 6044
			// (get) Token: 0x06005C65 RID: 23653 RVA: 0x001A3548 File Offset: 0x001A1748
			// (set) Token: 0x06005C66 RID: 23654 RVA: 0x00021824 File Offset: 0x0001FA24
			public unsafe CultureInfo _currentCulture_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr__currentCulture_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceFallbackManager._GetEnumerator_d__5.NativeFieldInfoPtr__currentCulture_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004B0D RID: 19213
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004B0E RID: 19214
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004B0F RID: 19215
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004B10 RID: 19216
			private static readonly IntPtr NativeFieldInfoPtr__reachedNeutralResourcesCulture_5__2;

			// Token: 0x04004B11 RID: 19217
			private static readonly IntPtr NativeFieldInfoPtr__currentCulture_5__3;

			// Token: 0x04004B12 RID: 19218
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004B13 RID: 19219
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004B14 RID: 19220
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004B15 RID: 19221
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Globalization_CultureInfo__get_Current_Private_Virtual_Final_New_get_CultureInfo_0;

			// Token: 0x04004B16 RID: 19222
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004B17 RID: 19223
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
