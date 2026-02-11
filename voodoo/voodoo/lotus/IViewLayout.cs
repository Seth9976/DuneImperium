using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace lotus
{
	// Token: 0x0200005A RID: 90
	public class IViewLayout : Il2CppObjectBase
	{
		// Token: 0x06000558 RID: 1368 RVA: 0x0001AFA0 File Offset: 0x000191A0
		// Note: this type is marked as 'beforefieldinit'.
		static IViewLayout()
		{
			Il2CppClassPointerStore<IViewLayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "IViewLayout");
			IViewLayout.NativeMethodInfoPtr_Layout_Public_Abstract_Virtual_New_Void_List_1_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IViewLayout>.NativeClassPtr, 100663978);
			IViewLayout.NativeMethodInfoPtr_GetSlotFor_Public_Abstract_Virtual_New_Transform_UnitView_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IViewLayout>.NativeClassPtr, 100663979);
			IViewLayout.NativeMethodInfoPtr_GetPositionsFor_Public_Virtual_New_Void_MoveContext_Il2CppStructArray_1_LocalTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IViewLayout>.NativeClassPtr, 100663980);
			IViewLayout.NativeMethodInfoPtr_OnPrepareToReceiveEntities_Public_Virtual_New_IEnumerator_MoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IViewLayout>.NativeClassPtr, 100663981);
			IViewLayout.NativeMethodInfoPtr_OnPrepareToRemoveEntities_Public_Virtual_New_IEnumerator_MoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IViewLayout>.NativeClassPtr, 100663982);
			IViewLayout.NativeMethodInfoPtr_OnViewsRemoved_Public_Virtual_New_Void_List_1_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IViewLayout>.NativeClassPtr, 100663983);
			IViewLayout.NativeMethodInfoPtr_Init_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IViewLayout>.NativeClassPtr, 100663984);
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x0001B054 File Offset: 0x00019254
		[CallerCount(0)]
		public unsafe virtual void Layout(List<UnitView> views)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(views);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IViewLayout.NativeMethodInfoPtr_Layout_Public_Abstract_Virtual_New_Void_List_1_UnitView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0001B0A4 File Offset: 0x000192A4
		[CallerCount(0)]
		public unsafe virtual Transform GetSlotFor(UnitView view, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(view);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IViewLayout.NativeMethodInfoPtr_GetSlotFor_Public_Abstract_Virtual_New_Transform_UnitView_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0001B110 File Offset: 0x00019310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111626, XrefRangeEnd = 1111634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetPositionsFor(MoveContext context, Il2CppStructArray<LocalTransform> retVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(retVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IViewLayout.NativeMethodInfoPtr_GetPositionsFor_Public_Virtual_New_Void_MoveContext_Il2CppStructArray_1_LocalTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0001B170 File Offset: 0x00019370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111634, XrefRangeEnd = 1111638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator OnPrepareToReceiveEntities(MoveContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IViewLayout.NativeMethodInfoPtr_OnPrepareToReceiveEntities_Public_Virtual_New_IEnumerator_MoveContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0001B1CC File Offset: 0x000193CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111638, XrefRangeEnd = 1111642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator OnPrepareToRemoveEntities(MoveContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IViewLayout.NativeMethodInfoPtr_OnPrepareToRemoveEntities_Public_Virtual_New_IEnumerator_MoveContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0001B228 File Offset: 0x00019428
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnViewsRemoved(List<UnitView> views)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(views);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IViewLayout.NativeMethodInfoPtr_OnViewsRemoved_Public_Virtual_New_Void_List_1_UnitView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0001B278 File Offset: 0x00019478
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IViewLayout.NativeMethodInfoPtr_Init_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x000049EF File Offset: 0x00002BEF
		public IViewLayout(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeMethodInfoPtr_Layout_Public_Abstract_Virtual_New_Void_List_1_UnitView_0;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeMethodInfoPtr_GetSlotFor_Public_Abstract_Virtual_New_Transform_UnitView_Int32_0;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeMethodInfoPtr_GetPositionsFor_Public_Virtual_New_Void_MoveContext_Il2CppStructArray_1_LocalTransform_0;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeMethodInfoPtr_OnPrepareToReceiveEntities_Public_Virtual_New_IEnumerator_MoveContext_0;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeMethodInfoPtr_OnPrepareToRemoveEntities_Public_Virtual_New_IEnumerator_MoveContext_0;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeMethodInfoPtr_OnViewsRemoved_Public_Virtual_New_Void_List_1_UnitView_0;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_New_Void_0;

		// Token: 0x020000DB RID: 219
		[ObfuscatedName("lotus.IViewLayout+<OnPrepareToReceiveEntities>d__3")]
		public sealed class _OnPrepareToReceiveEntities_d__3 : global::Il2CppSystem.Object
		{
			// Token: 0x06000B79 RID: 2937 RVA: 0x0002ED34 File Offset: 0x0002CF34
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPrepareToReceiveEntities_d__3()
			{
				Il2CppClassPointerStore<IViewLayout._OnPrepareToReceiveEntities_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IViewLayout>.NativeClassPtr, "<OnPrepareToReceiveEntities>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IViewLayout._OnPrepareToReceiveEntities_d__3>.NativeClassPtr);
				IViewLayout._OnPrepareToReceiveEntities_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IViewLayout._OnPrepareToReceiveEntities_d__3>.NativeClassPtr, "<>1__state");
				IViewLayout._OnPrepareToReceiveEntities_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IViewLayout._OnPrepareToReceiveEntities_d__3>.NativeClassPtr, "<>2__current");
				IViewLayout._OnPrepareToReceiveEntities_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IViewLayout._OnPrepareToReceiveEntities_d__3>.NativeClassPtr, 100663985);
				IViewLayout._OnPrepareToReceiveEntities_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IViewLayout._OnPrepareToReceiveEntities_d__3>.NativeClassPtr, 100663986);
				IViewLayout._OnPrepareToReceiveEntities_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IViewLayout._OnPrepareToReceiveEntities_d__3>.NativeClassPtr, 100663987);
				IViewLayout._OnPrepareToReceiveEntities_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IViewLayout._OnPrepareToReceiveEntities_d__3>.NativeClassPtr, 100663988);
				IViewLayout._OnPrepareToReceiveEntities_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IViewLayout._OnPrepareToReceiveEntities_d__3>.NativeClassPtr, 100663989);
				IViewLayout._OnPrepareToReceiveEntities_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IViewLayout._OnPrepareToReceiveEntities_d__3>.NativeClassPtr, 100663990);
			}

			// Token: 0x06000B7A RID: 2938 RVA: 0x0002EE00 File Offset: 0x0002D000
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPrepareToReceiveEntities_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IViewLayout._OnPrepareToReceiveEntities_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IViewLayout._OnPrepareToReceiveEntities_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000B7B RID: 2939 RVA: 0x0002EE48 File Offset: 0x0002D048
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IViewLayout._OnPrepareToReceiveEntities_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000B7C RID: 2940 RVA: 0x0002EE7C File Offset: 0x0002D07C
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IViewLayout._OnPrepareToReceiveEntities_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700035C RID: 860
			// (get) Token: 0x06000B7D RID: 2941 RVA: 0x0002EEB8 File Offset: 0x0002D0B8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IViewLayout._OnPrepareToReceiveEntities_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000B7E RID: 2942 RVA: 0x0002EEF8 File Offset: 0x0002D0F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111616, XrefRangeEnd = 1111621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IViewLayout._OnPrepareToReceiveEntities_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700035D RID: 861
			// (get) Token: 0x06000B7F RID: 2943 RVA: 0x0002EF2C File Offset: 0x0002D12C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IViewLayout._OnPrepareToReceiveEntities_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000B80 RID: 2944 RVA: 0x00007A3B File Offset: 0x00005C3B
			public _OnPrepareToReceiveEntities_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700035A RID: 858
			// (get) Token: 0x06000B81 RID: 2945 RVA: 0x0002EF6C File Offset: 0x0002D16C
			// (set) Token: 0x06000B82 RID: 2946 RVA: 0x00007A44 File Offset: 0x00005C44
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IViewLayout._OnPrepareToReceiveEntities_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IViewLayout._OnPrepareToReceiveEntities_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700035B RID: 859
			// (get) Token: 0x06000B83 RID: 2947 RVA: 0x0002EF94 File Offset: 0x0002D194
			// (set) Token: 0x06000B84 RID: 2948 RVA: 0x00007A5F File Offset: 0x00005C5F
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IViewLayout._OnPrepareToReceiveEntities_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IViewLayout._OnPrepareToReceiveEntities_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400072A RID: 1834
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400072B RID: 1835
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400072C RID: 1836
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400072D RID: 1837
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400072E RID: 1838
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400072F RID: 1839
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000730 RID: 1840
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000731 RID: 1841
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020000DC RID: 220
		[ObfuscatedName("lotus.IViewLayout+<OnPrepareToRemoveEntities>d__4")]
		public sealed class _OnPrepareToRemoveEntities_d__4 : global::Il2CppSystem.Object
		{
			// Token: 0x06000B85 RID: 2949 RVA: 0x0002EFC4 File Offset: 0x0002D1C4
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPrepareToRemoveEntities_d__4()
			{
				Il2CppClassPointerStore<IViewLayout._OnPrepareToRemoveEntities_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IViewLayout>.NativeClassPtr, "<OnPrepareToRemoveEntities>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IViewLayout._OnPrepareToRemoveEntities_d__4>.NativeClassPtr);
				IViewLayout._OnPrepareToRemoveEntities_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IViewLayout._OnPrepareToRemoveEntities_d__4>.NativeClassPtr, "<>1__state");
				IViewLayout._OnPrepareToRemoveEntities_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IViewLayout._OnPrepareToRemoveEntities_d__4>.NativeClassPtr, "<>2__current");
				IViewLayout._OnPrepareToRemoveEntities_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IViewLayout._OnPrepareToRemoveEntities_d__4>.NativeClassPtr, 100663991);
				IViewLayout._OnPrepareToRemoveEntities_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IViewLayout._OnPrepareToRemoveEntities_d__4>.NativeClassPtr, 100663992);
				IViewLayout._OnPrepareToRemoveEntities_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IViewLayout._OnPrepareToRemoveEntities_d__4>.NativeClassPtr, 100663993);
				IViewLayout._OnPrepareToRemoveEntities_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IViewLayout._OnPrepareToRemoveEntities_d__4>.NativeClassPtr, 100663994);
				IViewLayout._OnPrepareToRemoveEntities_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IViewLayout._OnPrepareToRemoveEntities_d__4>.NativeClassPtr, 100663995);
				IViewLayout._OnPrepareToRemoveEntities_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IViewLayout._OnPrepareToRemoveEntities_d__4>.NativeClassPtr, 100663996);
			}

			// Token: 0x06000B86 RID: 2950 RVA: 0x0002F090 File Offset: 0x0002D290
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPrepareToRemoveEntities_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IViewLayout._OnPrepareToRemoveEntities_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IViewLayout._OnPrepareToRemoveEntities_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000B87 RID: 2951 RVA: 0x0002F0D8 File Offset: 0x0002D2D8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IViewLayout._OnPrepareToRemoveEntities_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000B88 RID: 2952 RVA: 0x0002F10C File Offset: 0x0002D30C
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IViewLayout._OnPrepareToRemoveEntities_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000360 RID: 864
			// (get) Token: 0x06000B89 RID: 2953 RVA: 0x0002F148 File Offset: 0x0002D348
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IViewLayout._OnPrepareToRemoveEntities_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000B8A RID: 2954 RVA: 0x0002F188 File Offset: 0x0002D388
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111621, XrefRangeEnd = 1111626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IViewLayout._OnPrepareToRemoveEntities_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000361 RID: 865
			// (get) Token: 0x06000B8B RID: 2955 RVA: 0x0002F1BC File Offset: 0x0002D3BC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IViewLayout._OnPrepareToRemoveEntities_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000B8C RID: 2956 RVA: 0x00007A7E File Offset: 0x00005C7E
			public _OnPrepareToRemoveEntities_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700035E RID: 862
			// (get) Token: 0x06000B8D RID: 2957 RVA: 0x0002F1FC File Offset: 0x0002D3FC
			// (set) Token: 0x06000B8E RID: 2958 RVA: 0x00007A87 File Offset: 0x00005C87
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IViewLayout._OnPrepareToRemoveEntities_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IViewLayout._OnPrepareToRemoveEntities_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700035F RID: 863
			// (get) Token: 0x06000B8F RID: 2959 RVA: 0x0002F224 File Offset: 0x0002D424
			// (set) Token: 0x06000B90 RID: 2960 RVA: 0x00007AA2 File Offset: 0x00005CA2
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IViewLayout._OnPrepareToRemoveEntities_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IViewLayout._OnPrepareToRemoveEntities_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000732 RID: 1842
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000733 RID: 1843
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000734 RID: 1844
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000735 RID: 1845
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000736 RID: 1846
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000737 RID: 1847
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000738 RID: 1848
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000739 RID: 1849
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
