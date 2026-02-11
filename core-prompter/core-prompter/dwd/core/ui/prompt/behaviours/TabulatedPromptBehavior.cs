using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace dwd.core.ui.prompt.behaviours
{
	// Token: 0x02000042 RID: 66
	public class TabulatedPromptBehavior<TPrompt> : PromptBehaviour<TPrompt> where TPrompt : class
	{
		// Token: 0x0600025F RID: 607 RVA: 0x0000B8F0 File Offset: 0x00009AF0
		// Note: this type is marked as 'beforefieldinit'.
		static TabulatedPromptBehavior()
		{
			Il2CppClassPointerStore<TabulatedPromptBehavior<TPrompt>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.behaviours", "TabulatedPromptBehavior`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPrompt>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TabulatedPromptBehavior<TPrompt>>.NativeClassPtr);
			TabulatedPromptBehavior<TPrompt>.NativeFieldInfoPtr_tabPagePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabulatedPromptBehavior<TPrompt>>.NativeClassPtr, "tabPagePairs");
			TabulatedPromptBehavior<TPrompt>.NativeFieldInfoPtr_tabRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabulatedPromptBehavior<TPrompt>>.NativeClassPtr, "tabRoot");
			TabulatedPromptBehavior<TPrompt>.NativeMethodInfoPtr_get_StartingTabIndex_Protected_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabulatedPromptBehavior<TPrompt>>.NativeClassPtr, 100663582);
			TabulatedPromptBehavior<TPrompt>.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabulatedPromptBehavior<TPrompt>>.NativeClassPtr, 100663583);
			TabulatedPromptBehavior<TPrompt>.NativeMethodInfoPtr_OpenStartingTab_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabulatedPromptBehavior<TPrompt>>.NativeClassPtr, 100663584);
			TabulatedPromptBehavior<TPrompt>.NativeMethodInfoPtr_Event_ChangeTab_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabulatedPromptBehavior<TPrompt>>.NativeClassPtr, 100663585);
			TabulatedPromptBehavior<TPrompt>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabulatedPromptBehavior<TPrompt>>.NativeClassPtr, 100663586);
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000260 RID: 608 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		public unsafe virtual int StartingTabIndex
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TabulatedPromptBehavior<TPrompt>.NativeMethodInfoPtr_get_StartingTabIndex_Protected_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000BA30 File Offset: 0x00009C30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1214834, RefRangeEnd = 1214836, XrefRangeStart = 1214829, XrefRangeEnd = 1214834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TabulatedPromptBehavior<TPrompt>.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000BA6C File Offset: 0x00009C6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1214852, RefRangeEnd = 1214853, XrefRangeStart = 1214836, XrefRangeEnd = 1214852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenStartingTab()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabulatedPromptBehavior<TPrompt>.NativeMethodInfoPtr_OpenStartingTab_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000BAA0 File Offset: 0x00009CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214853, XrefRangeEnd = 1214884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_ChangeTab(int direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref direction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TabulatedPromptBehavior<TPrompt>.NativeMethodInfoPtr_Event_ChangeTab_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000BAEC File Offset: 0x00009CEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1214890, RefRangeEnd = 1214892, XrefRangeStart = 1214884, XrefRangeEnd = 1214890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TabulatedPromptBehavior()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TabulatedPromptBehavior<TPrompt>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabulatedPromptBehavior<TPrompt>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000334F File Offset: 0x0000154F
		public TabulatedPromptBehavior(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0000BB28 File Offset: 0x00009D28
		// (set) Token: 0x06000267 RID: 615 RVA: 0x00003358 File Offset: 0x00001558
		public unsafe Il2CppReferenceArray<TabulatedPromptBehavior<TPrompt>.TabPagePair> tabPagePairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabulatedPromptBehavior<TPrompt>.NativeFieldInfoPtr_tabPagePairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TabulatedPromptBehavior<TPrompt>.TabPagePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabulatedPromptBehavior<TPrompt>.NativeFieldInfoPtr_tabPagePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0000BB58 File Offset: 0x00009D58
		// (set) Token: 0x06000269 RID: 617 RVA: 0x00003377 File Offset: 0x00001577
		public unsafe Transform tabRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabulatedPromptBehavior<TPrompt>.NativeFieldInfoPtr_tabRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabulatedPromptBehavior<TPrompt>.NativeFieldInfoPtr_tabRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeFieldInfoPtr_tabPagePairs;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeFieldInfoPtr_tabRoot;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_get_StartingTabIndex_Protected_Virtual_New_get_Int32_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_OpenStartingTab_Protected_Void_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_Event_ChangeTab_Public_Virtual_New_Void_Int32_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0200005A RID: 90
		[Serializable]
		public sealed class TabPagePair : ValueType
		{
			// Token: 0x06000398 RID: 920 RVA: 0x0000F5F8 File Offset: 0x0000D7F8
			// Note: this type is marked as 'beforefieldinit'.
			static TabPagePair()
			{
				Il2CppClassPointerStore<TabulatedPromptBehavior<TPrompt>.TabPagePair>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TabulatedPromptBehavior<TPrompt>>.NativeClassPtr, "TabPagePair"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPrompt>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TabulatedPromptBehavior<TPrompt>.TabPagePair>.NativeClassPtr);
				TabulatedPromptBehavior<TPrompt>.TabPagePair.NativeFieldInfoPtr_page = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabulatedPromptBehavior<TPrompt>.TabPagePair>.NativeClassPtr, "page");
				TabulatedPromptBehavior<TPrompt>.TabPagePair.NativeFieldInfoPtr_tab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabulatedPromptBehavior<TPrompt>.TabPagePair>.NativeClassPtr, "tab");
			}

			// Token: 0x06000399 RID: 921 RVA: 0x00003D0E File Offset: 0x00001F0E
			public TabPagePair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600039A RID: 922 RVA: 0x00003D17 File Offset: 0x00001F17
			public TabPagePair()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TabulatedPromptBehavior<TPrompt>.TabPagePair>.NativeClassPtr))
			{
			}

			// Token: 0x1700012D RID: 301
			// (get) Token: 0x0600039B RID: 923 RVA: 0x0000F688 File Offset: 0x0000D888
			// (set) Token: 0x0600039C RID: 924 RVA: 0x00003D29 File Offset: 0x00001F29
			public unsafe TabulatedPromptPage page
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabulatedPromptBehavior<TPrompt>.TabPagePair.NativeFieldInfoPtr_page);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TabulatedPromptPage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabulatedPromptBehavior<TPrompt>.TabPagePair.NativeFieldInfoPtr_page), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700012E RID: 302
			// (get) Token: 0x0600039D RID: 925 RVA: 0x0000F6B8 File Offset: 0x0000D8B8
			// (set) Token: 0x0600039E RID: 926 RVA: 0x00003D48 File Offset: 0x00001F48
			public unsafe Toggle tab
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabulatedPromptBehavior<TPrompt>.TabPagePair.NativeFieldInfoPtr_tab);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabulatedPromptBehavior<TPrompt>.TabPagePair.NativeFieldInfoPtr_tab), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400020B RID: 523
			private static readonly IntPtr NativeFieldInfoPtr_page;

			// Token: 0x0400020C RID: 524
			private static readonly IntPtr NativeFieldInfoPtr_tab;
		}

		// Token: 0x0200005B RID: 91
		[ObfuscatedName("dwd.core.ui.prompt.behaviours.TabulatedPromptBehavior`1+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x0600039F RID: 927 RVA: 0x0000F6E8 File Offset: 0x0000D8E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TabulatedPromptBehavior<TPrompt>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TabulatedPromptBehavior<TPrompt>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPrompt>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TabulatedPromptBehavior<TPrompt>.__c>.NativeClassPtr);
				TabulatedPromptBehavior<TPrompt>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabulatedPromptBehavior<TPrompt>.__c>.NativeClassPtr, "<>9");
				TabulatedPromptBehavior<TPrompt>.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabulatedPromptBehavior<TPrompt>.__c>.NativeClassPtr, "<>9__6_0");
				TabulatedPromptBehavior<TPrompt>.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabulatedPromptBehavior<TPrompt>.__c>.NativeClassPtr, "<>9__7_0");
				TabulatedPromptBehavior<TPrompt>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabulatedPromptBehavior<TPrompt>.__c>.NativeClassPtr, 100663588);
				TabulatedPromptBehavior<TPrompt>.__c.NativeMethodInfoPtr__OpenStartingTab_b__6_0_Internal_Boolean_TabPagePair_TPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabulatedPromptBehavior<TPrompt>.__c>.NativeClassPtr, 100663589);
				TabulatedPromptBehavior<TPrompt>.__c.NativeMethodInfoPtr__Event_ChangeTab_b__7_0_Internal_Boolean_TabPagePair_TPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabulatedPromptBehavior<TPrompt>.__c>.NativeClassPtr, 100663590);
			}

			// Token: 0x060003A0 RID: 928 RVA: 0x0000F7C8 File Offset: 0x0000D9C8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TabulatedPromptBehavior<TPrompt>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabulatedPromptBehavior<TPrompt>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003A1 RID: 929 RVA: 0x0000F804 File Offset: 0x0000DA04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214828, XrefRangeEnd = 1214829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OpenStartingTab_b__6_0(TabulatedPromptBehavior<TPrompt>.TabPagePair pair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabulatedPromptBehavior<TPrompt>.__c.NativeMethodInfoPtr__OpenStartingTab_b__6_0_Internal_Boolean_TabPagePair_TPrompt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060003A2 RID: 930 RVA: 0x0000F858 File Offset: 0x0000DA58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Event_ChangeTab_b__7_0(TabulatedPromptBehavior<TPrompt>.TabPagePair pair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabulatedPromptBehavior<TPrompt>.__c.NativeMethodInfoPtr__Event_ChangeTab_b__7_0_Internal_Boolean_TabPagePair_TPrompt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060003A3 RID: 931 RVA: 0x00003D67 File Offset: 0x00001F67
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700012F RID: 303
			// (get) Token: 0x060003A4 RID: 932 RVA: 0x0000F8AC File Offset: 0x0000DAAC
			// (set) Token: 0x060003A5 RID: 933 RVA: 0x00003D70 File Offset: 0x00001F70
			public unsafe static TabulatedPromptBehavior<TPrompt>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TabulatedPromptBehavior<TPrompt>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TabulatedPromptBehavior<TPrompt>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TabulatedPromptBehavior<TPrompt>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000130 RID: 304
			// (get) Token: 0x060003A6 RID: 934 RVA: 0x0000F8D4 File Offset: 0x0000DAD4
			// (set) Token: 0x060003A7 RID: 935 RVA: 0x00003D82 File Offset: 0x00001F82
			public unsafe static Func<TabulatedPromptBehavior<TPrompt>.TabPagePair, bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TabulatedPromptBehavior<TPrompt>.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TabulatedPromptBehavior<TPrompt>.TabPagePair, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TabulatedPromptBehavior<TPrompt>.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000131 RID: 305
			// (get) Token: 0x060003A8 RID: 936 RVA: 0x0000F8FC File Offset: 0x0000DAFC
			// (set) Token: 0x060003A9 RID: 937 RVA: 0x00003D94 File Offset: 0x00001F94
			public unsafe static Func<TabulatedPromptBehavior<TPrompt>.TabPagePair, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TabulatedPromptBehavior<TPrompt>.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TabulatedPromptBehavior<TPrompt>.TabPagePair, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TabulatedPromptBehavior<TPrompt>.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400020D RID: 525
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400020E RID: 526
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x0400020F RID: 527
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04000210 RID: 528
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000211 RID: 529
			private static readonly IntPtr NativeMethodInfoPtr__OpenStartingTab_b__6_0_Internal_Boolean_TabPagePair_TPrompt_0;

			// Token: 0x04000212 RID: 530
			private static readonly IntPtr NativeMethodInfoPtr__Event_ChangeTab_b__7_0_Internal_Boolean_TabPagePair_TPrompt_0;
		}

		// Token: 0x0200005C RID: 92
		[ObfuscatedName("dwd.core.ui.prompt.behaviours.TabulatedPromptBehavior`1+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060003AA RID: 938 RVA: 0x0000F924 File Offset: 0x0000DB24
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<TabulatedPromptBehavior<TPrompt>.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TabulatedPromptBehavior<TPrompt>>.NativeClassPtr, "<>c__DisplayClass7_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPrompt>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TabulatedPromptBehavior<TPrompt>.__c__DisplayClass7_0>.NativeClassPtr);
				TabulatedPromptBehavior<TPrompt>.__c__DisplayClass7_0.NativeFieldInfoPtr_currentTabType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabulatedPromptBehavior<TPrompt>.__c__DisplayClass7_0>.NativeClassPtr, "currentTabType");
				TabulatedPromptBehavior<TPrompt>.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabulatedPromptBehavior<TPrompt>.__c__DisplayClass7_0>.NativeClassPtr, 100663591);
				TabulatedPromptBehavior<TPrompt>.__c__DisplayClass7_0.NativeMethodInfoPtr__Event_ChangeTab_b__1_Internal_Boolean_TabPagePair_TPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabulatedPromptBehavior<TPrompt>.__c__DisplayClass7_0>.NativeClassPtr, 100663592);
			}

			// Token: 0x060003AB RID: 939 RVA: 0x0000F9C8 File Offset: 0x0000DBC8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TabulatedPromptBehavior<TPrompt>.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabulatedPromptBehavior<TPrompt>.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003AC RID: 940 RVA: 0x0000FA04 File Offset: 0x0000DC04
			[CallerCount(0)]
			public unsafe bool _Event_ChangeTab_b__1(TabulatedPromptBehavior<TPrompt>.TabPagePair pair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabulatedPromptBehavior<TPrompt>.__c__DisplayClass7_0.NativeMethodInfoPtr__Event_ChangeTab_b__1_Internal_Boolean_TabPagePair_TPrompt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060003AD RID: 941 RVA: 0x00003DA6 File Offset: 0x00001FA6
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000132 RID: 306
			// (get) Token: 0x060003AE RID: 942 RVA: 0x0000FA58 File Offset: 0x0000DC58
			// (set) Token: 0x060003AF RID: 943 RVA: 0x00003DAF File Offset: 0x00001FAF
			public unsafe int currentTabType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabulatedPromptBehavior<TPrompt>.__c__DisplayClass7_0.NativeFieldInfoPtr_currentTabType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabulatedPromptBehavior<TPrompt>.__c__DisplayClass7_0.NativeFieldInfoPtr_currentTabType)) = value;
				}
			}

			// Token: 0x04000213 RID: 531
			private static readonly IntPtr NativeFieldInfoPtr_currentTabType;

			// Token: 0x04000214 RID: 532
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000215 RID: 533
			private static readonly IntPtr NativeMethodInfoPtr__Event_ChangeTab_b__1_Internal_Boolean_TabPagePair_TPrompt_0;
		}
	}
}
