using System;
using dwd.core.match;
using dwd.core.prefabs.implementations.byflavor;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;

namespace voodoo.flavors
{
	// Token: 0x0200003C RID: 60
	public class GameSpecificContextExtensions : MonoBehaviour
	{
		// Token: 0x060003E3 RID: 995 RVA: 0x0001592C File Offset: 0x00013B2C
		// Note: this type is marked as 'beforefieldinit'.
		static GameSpecificContextExtensions()
		{
			Il2CppClassPointerStore<GameSpecificContextExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.flavors", "GameSpecificContextExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameSpecificContextExtensions>.NativeClassPtr);
			GameSpecificContextExtensions.NativeMethodInfoPtr_WithEntityContext_Public_Virtual_New_IEnumerable_1_String_PrefabFlavorContext_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSpecificContextExtensions>.NativeClassPtr, 100663715);
			GameSpecificContextExtensions.NativeMethodInfoPtr_WithPileContext_Public_Virtual_New_IEnumerable_1_String_PrefabFlavorContext_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSpecificContextExtensions>.NativeClassPtr, 100663716);
			GameSpecificContextExtensions.NativeMethodInfoPtr_WithMoveContext_Public_Virtual_New_IEnumerable_1_String_PrefabFlavorContext_MoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSpecificContextExtensions>.NativeClassPtr, 100663717);
			GameSpecificContextExtensions.NativeMethodInfoPtr_GetMovePileName_Public_Virtual_New_String_ContainerView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSpecificContextExtensions>.NativeClassPtr, 100663718);
			GameSpecificContextExtensions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSpecificContextExtensions>.NativeClassPtr, 100663719);
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x000159C0 File Offset: 0x00013BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109559, XrefRangeEnd = 1109564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<string> WithEntityContext(PrefabFlavorContext context, EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameSpecificContextExtensions.NativeMethodInfoPtr_WithEntityContext_Public_Virtual_New_IEnumerable_1_String_PrefabFlavorContext_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00015A34 File Offset: 0x00013C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109564, XrefRangeEnd = 1109568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<string> WithPileContext(PrefabFlavorContext context, Component component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(component);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameSpecificContextExtensions.NativeMethodInfoPtr_WithPileContext_Public_Virtual_New_IEnumerable_1_String_PrefabFlavorContext_Component_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00015AA8 File Offset: 0x00013CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109568, XrefRangeEnd = 1109572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<string> WithMoveContext(PrefabFlavorContext context, MoveContext moveContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(moveContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameSpecificContextExtensions.NativeMethodInfoPtr_WithMoveContext_Public_Virtual_New_IEnumerable_1_String_PrefabFlavorContext_MoveContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00015B1C File Offset: 0x00013D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109572, XrefRangeEnd = 1109574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetMovePileName(ContainerView container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameSpecificContextExtensions.NativeMethodInfoPtr_GetMovePileName_Public_Virtual_New_String_ContainerView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00015B70 File Offset: 0x00013D70
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameSpecificContextExtensions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameSpecificContextExtensions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSpecificContextExtensions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00004052 File Offset: 0x00002252
		public GameSpecificContextExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeMethodInfoPtr_WithEntityContext_Public_Virtual_New_IEnumerable_1_String_PrefabFlavorContext_EntityComponent_0;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeMethodInfoPtr_WithPileContext_Public_Virtual_New_IEnumerable_1_String_PrefabFlavorContext_Component_0;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeMethodInfoPtr_WithMoveContext_Public_Virtual_New_IEnumerable_1_String_PrefabFlavorContext_MoveContext_0;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeMethodInfoPtr_GetMovePileName_Public_Virtual_New_String_ContainerView_0;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000C9 RID: 201
		[ObfuscatedName("voodoo.flavors.GameSpecificContextExtensions+<WithEntityContext>d__0")]
		public sealed class _WithEntityContext_d__0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000A9A RID: 2714 RVA: 0x0002C20C File Offset: 0x0002A40C
			// Note: this type is marked as 'beforefieldinit'.
			static _WithEntityContext_d__0()
			{
				Il2CppClassPointerStore<GameSpecificContextExtensions._WithEntityContext_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameSpecificContextExtensions>.NativeClassPtr, "<WithEntityContext>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameSpecificContextExtensions._WithEntityContext_d__0>.NativeClassPtr);
				GameSpecificContextExtensions._WithEntityContext_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSpecificContextExtensions._WithEntityContext_d__0>.NativeClassPtr, "<>1__state");
				GameSpecificContextExtensions._WithEntityContext_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSpecificContextExtensions._WithEntityContext_d__0>.NativeClassPtr, "<>2__current");
				GameSpecificContextExtensions._WithEntityContext_d__0.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSpecificContextExtensions._WithEntityContext_d__0>.NativeClassPtr, "<>l__initialThreadId");
				GameSpecificContextExtensions._WithEntityContext_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSpecificContextExtensions._WithEntityContext_d__0>.NativeClassPtr, 100663720);
				GameSpecificContextExtensions._WithEntityContext_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSpecificContextExtensions._WithEntityContext_d__0>.NativeClassPtr, 100663721);
				GameSpecificContextExtensions._WithEntityContext_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSpecificContextExtensions._WithEntityContext_d__0>.NativeClassPtr, 100663722);
				GameSpecificContextExtensions._WithEntityContext_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSpecificContextExtensions._WithEntityContext_d__0>.NativeClassPtr, 100663723);
				GameSpecificContextExtensions._WithEntityContext_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSpecificContextExtensions._WithEntityContext_d__0>.NativeClassPtr, 100663724);
				GameSpecificContextExtensions._WithEntityContext_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSpecificContextExtensions._WithEntityContext_d__0>.NativeClassPtr, 100663725);
				GameSpecificContextExtensions._WithEntityContext_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSpecificContextExtensions._WithEntityContext_d__0>.NativeClassPtr, 100663726);
				GameSpecificContextExtensions._WithEntityContext_d__0.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSpecificContextExtensions._WithEntityContext_d__0>.NativeClassPtr, 100663727);
			}

			// Token: 0x06000A9B RID: 2715 RVA: 0x0002C314 File Offset: 0x0002A514
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _WithEntityContext_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameSpecificContextExtensions._WithEntityContext_d__0>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSpecificContextExtensions._WithEntityContext_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000A9C RID: 2716 RVA: 0x0002C35C File Offset: 0x0002A55C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSpecificContextExtensions._WithEntityContext_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000A9D RID: 2717 RVA: 0x0002C390 File Offset: 0x0002A590
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSpecificContextExtensions._WithEntityContext_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000310 RID: 784
			// (get) Token: 0x06000A9E RID: 2718 RVA: 0x0002C3CC File Offset: 0x0002A5CC
			public unsafe string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSpecificContextExtensions._WithEntityContext_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000A9F RID: 2719 RVA: 0x0002C404 File Offset: 0x0002A604
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109538, XrefRangeEnd = 1109543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSpecificContextExtensions._WithEntityContext_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000311 RID: 785
			// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x0002C438 File Offset: 0x0002A638
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSpecificContextExtensions._WithEntityContext_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000AA1 RID: 2721 RVA: 0x0002C478 File Offset: 0x0002A678
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109543, XrefRangeEnd = 1109545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<string> System_Collections_Generic_IEnumerable_System_String__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSpecificContextExtensions._WithEntityContext_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<string>>(intPtr3) : null;
			}

			// Token: 0x06000AA2 RID: 2722 RVA: 0x0002C4B8 File Offset: 0x0002A6B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSpecificContextExtensions._WithEntityContext_d__0.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06000AA3 RID: 2723 RVA: 0x000073A9 File Offset: 0x000055A9
			public _WithEntityContext_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700030D RID: 781
			// (get) Token: 0x06000AA4 RID: 2724 RVA: 0x0002C4F8 File Offset: 0x0002A6F8
			// (set) Token: 0x06000AA5 RID: 2725 RVA: 0x000073B2 File Offset: 0x000055B2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSpecificContextExtensions._WithEntityContext_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSpecificContextExtensions._WithEntityContext_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700030E RID: 782
			// (get) Token: 0x06000AA6 RID: 2726 RVA: 0x0002C520 File Offset: 0x0002A720
			// (set) Token: 0x06000AA7 RID: 2727 RVA: 0x000073CD File Offset: 0x000055CD
			public unsafe string __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSpecificContextExtensions._WithEntityContext_d__0.NativeFieldInfoPtr___2__current);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSpecificContextExtensions._WithEntityContext_d__0.NativeFieldInfoPtr___2__current), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700030F RID: 783
			// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x0002C548 File Offset: 0x0002A748
			// (set) Token: 0x06000AA9 RID: 2729 RVA: 0x000073EC File Offset: 0x000055EC
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSpecificContextExtensions._WithEntityContext_d__0.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSpecificContextExtensions._WithEntityContext_d__0.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x0400069B RID: 1691
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400069C RID: 1692
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400069D RID: 1693
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400069E RID: 1694
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400069F RID: 1695
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040006A0 RID: 1696
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040006A1 RID: 1697
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0;

			// Token: 0x040006A2 RID: 1698
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040006A3 RID: 1699
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040006A4 RID: 1700
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0;

			// Token: 0x040006A5 RID: 1701
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020000CA RID: 202
		[ObfuscatedName("voodoo.flavors.GameSpecificContextExtensions+<WithMoveContext>d__2")]
		public sealed class _WithMoveContext_d__2 : global::Il2CppSystem.Object
		{
			// Token: 0x06000AAA RID: 2730 RVA: 0x0002C570 File Offset: 0x0002A770
			// Note: this type is marked as 'beforefieldinit'.
			static _WithMoveContext_d__2()
			{
				Il2CppClassPointerStore<GameSpecificContextExtensions._WithMoveContext_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameSpecificContextExtensions>.NativeClassPtr, "<WithMoveContext>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameSpecificContextExtensions._WithMoveContext_d__2>.NativeClassPtr);
				GameSpecificContextExtensions._WithMoveContext_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSpecificContextExtensions._WithMoveContext_d__2>.NativeClassPtr, "<>1__state");
				GameSpecificContextExtensions._WithMoveContext_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSpecificContextExtensions._WithMoveContext_d__2>.NativeClassPtr, "<>2__current");
				GameSpecificContextExtensions._WithMoveContext_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSpecificContextExtensions._WithMoveContext_d__2>.NativeClassPtr, "<>l__initialThreadId");
				GameSpecificContextExtensions._WithMoveContext_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSpecificContextExtensions._WithMoveContext_d__2>.NativeClassPtr, 100663728);
				GameSpecificContextExtensions._WithMoveContext_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSpecificContextExtensions._WithMoveContext_d__2>.NativeClassPtr, 100663729);
				GameSpecificContextExtensions._WithMoveContext_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSpecificContextExtensions._WithMoveContext_d__2>.NativeClassPtr, 100663730);
				GameSpecificContextExtensions._WithMoveContext_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSpecificContextExtensions._WithMoveContext_d__2>.NativeClassPtr, 100663731);
				GameSpecificContextExtensions._WithMoveContext_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSpecificContextExtensions._WithMoveContext_d__2>.NativeClassPtr, 100663732);
				GameSpecificContextExtensions._WithMoveContext_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSpecificContextExtensions._WithMoveContext_d__2>.NativeClassPtr, 100663733);
				GameSpecificContextExtensions._WithMoveContext_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSpecificContextExtensions._WithMoveContext_d__2>.NativeClassPtr, 100663734);
				GameSpecificContextExtensions._WithMoveContext_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSpecificContextExtensions._WithMoveContext_d__2>.NativeClassPtr, 100663735);
			}

			// Token: 0x06000AAB RID: 2731 RVA: 0x0002C678 File Offset: 0x0002A878
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _WithMoveContext_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameSpecificContextExtensions._WithMoveContext_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSpecificContextExtensions._WithMoveContext_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000AAC RID: 2732 RVA: 0x0002C6C0 File Offset: 0x0002A8C0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSpecificContextExtensions._WithMoveContext_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000AAD RID: 2733 RVA: 0x0002C6F4 File Offset: 0x0002A8F4
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSpecificContextExtensions._WithMoveContext_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000315 RID: 789
			// (get) Token: 0x06000AAE RID: 2734 RVA: 0x0002C730 File Offset: 0x0002A930
			public unsafe string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSpecificContextExtensions._WithMoveContext_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000AAF RID: 2735 RVA: 0x0002C768 File Offset: 0x0002A968
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109545, XrefRangeEnd = 1109550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSpecificContextExtensions._WithMoveContext_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000316 RID: 790
			// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x0002C79C File Offset: 0x0002A99C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSpecificContextExtensions._WithMoveContext_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000AB1 RID: 2737 RVA: 0x0002C7DC File Offset: 0x0002A9DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109550, XrefRangeEnd = 1109552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<string> System_Collections_Generic_IEnumerable_System_String__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSpecificContextExtensions._WithMoveContext_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<string>>(intPtr3) : null;
			}

			// Token: 0x06000AB2 RID: 2738 RVA: 0x0002C81C File Offset: 0x0002AA1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSpecificContextExtensions._WithMoveContext_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06000AB3 RID: 2739 RVA: 0x00007407 File Offset: 0x00005607
			public _WithMoveContext_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000312 RID: 786
			// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x0002C85C File Offset: 0x0002AA5C
			// (set) Token: 0x06000AB5 RID: 2741 RVA: 0x00007410 File Offset: 0x00005610
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSpecificContextExtensions._WithMoveContext_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSpecificContextExtensions._WithMoveContext_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000313 RID: 787
			// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x0002C884 File Offset: 0x0002AA84
			// (set) Token: 0x06000AB7 RID: 2743 RVA: 0x0000742B File Offset: 0x0000562B
			public unsafe string __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSpecificContextExtensions._WithMoveContext_d__2.NativeFieldInfoPtr___2__current);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSpecificContextExtensions._WithMoveContext_d__2.NativeFieldInfoPtr___2__current), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000314 RID: 788
			// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x0002C8AC File Offset: 0x0002AAAC
			// (set) Token: 0x06000AB9 RID: 2745 RVA: 0x0000744A File Offset: 0x0000564A
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSpecificContextExtensions._WithMoveContext_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSpecificContextExtensions._WithMoveContext_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x040006A6 RID: 1702
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040006A7 RID: 1703
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040006A8 RID: 1704
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040006A9 RID: 1705
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040006AA RID: 1706
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040006AB RID: 1707
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040006AC RID: 1708
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0;

			// Token: 0x040006AD RID: 1709
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040006AE RID: 1710
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040006AF RID: 1711
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0;

			// Token: 0x040006B0 RID: 1712
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020000CB RID: 203
		[ObfuscatedName("voodoo.flavors.GameSpecificContextExtensions+<WithPileContext>d__1")]
		public sealed class _WithPileContext_d__1 : global::Il2CppSystem.Object
		{
			// Token: 0x06000ABA RID: 2746 RVA: 0x0002C8D4 File Offset: 0x0002AAD4
			// Note: this type is marked as 'beforefieldinit'.
			static _WithPileContext_d__1()
			{
				Il2CppClassPointerStore<GameSpecificContextExtensions._WithPileContext_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameSpecificContextExtensions>.NativeClassPtr, "<WithPileContext>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameSpecificContextExtensions._WithPileContext_d__1>.NativeClassPtr);
				GameSpecificContextExtensions._WithPileContext_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSpecificContextExtensions._WithPileContext_d__1>.NativeClassPtr, "<>1__state");
				GameSpecificContextExtensions._WithPileContext_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSpecificContextExtensions._WithPileContext_d__1>.NativeClassPtr, "<>2__current");
				GameSpecificContextExtensions._WithPileContext_d__1.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSpecificContextExtensions._WithPileContext_d__1>.NativeClassPtr, "<>l__initialThreadId");
				GameSpecificContextExtensions._WithPileContext_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSpecificContextExtensions._WithPileContext_d__1>.NativeClassPtr, 100663736);
				GameSpecificContextExtensions._WithPileContext_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSpecificContextExtensions._WithPileContext_d__1>.NativeClassPtr, 100663737);
				GameSpecificContextExtensions._WithPileContext_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSpecificContextExtensions._WithPileContext_d__1>.NativeClassPtr, 100663738);
				GameSpecificContextExtensions._WithPileContext_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSpecificContextExtensions._WithPileContext_d__1>.NativeClassPtr, 100663739);
				GameSpecificContextExtensions._WithPileContext_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSpecificContextExtensions._WithPileContext_d__1>.NativeClassPtr, 100663740);
				GameSpecificContextExtensions._WithPileContext_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSpecificContextExtensions._WithPileContext_d__1>.NativeClassPtr, 100663741);
				GameSpecificContextExtensions._WithPileContext_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSpecificContextExtensions._WithPileContext_d__1>.NativeClassPtr, 100663742);
				GameSpecificContextExtensions._WithPileContext_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSpecificContextExtensions._WithPileContext_d__1>.NativeClassPtr, 100663743);
			}

			// Token: 0x06000ABB RID: 2747 RVA: 0x0002C9DC File Offset: 0x0002ABDC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _WithPileContext_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameSpecificContextExtensions._WithPileContext_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSpecificContextExtensions._WithPileContext_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000ABC RID: 2748 RVA: 0x0002CA24 File Offset: 0x0002AC24
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSpecificContextExtensions._WithPileContext_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000ABD RID: 2749 RVA: 0x0002CA58 File Offset: 0x0002AC58
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSpecificContextExtensions._WithPileContext_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700031A RID: 794
			// (get) Token: 0x06000ABE RID: 2750 RVA: 0x0002CA94 File Offset: 0x0002AC94
			public unsafe string System.Collections.Generic.IEnumerator<System.String>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSpecificContextExtensions._WithPileContext_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000ABF RID: 2751 RVA: 0x0002CACC File Offset: 0x0002ACCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109552, XrefRangeEnd = 1109557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSpecificContextExtensions._WithPileContext_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700031B RID: 795
			// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x0002CB00 File Offset: 0x0002AD00
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSpecificContextExtensions._WithPileContext_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000AC1 RID: 2753 RVA: 0x0002CB40 File Offset: 0x0002AD40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109557, XrefRangeEnd = 1109559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<string> System_Collections_Generic_IEnumerable_System_String__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSpecificContextExtensions._WithPileContext_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<string>>(intPtr3) : null;
			}

			// Token: 0x06000AC2 RID: 2754 RVA: 0x0002CB80 File Offset: 0x0002AD80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSpecificContextExtensions._WithPileContext_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06000AC3 RID: 2755 RVA: 0x00007465 File Offset: 0x00005665
			public _WithPileContext_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000317 RID: 791
			// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x0002CBC0 File Offset: 0x0002ADC0
			// (set) Token: 0x06000AC5 RID: 2757 RVA: 0x0000746E File Offset: 0x0000566E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSpecificContextExtensions._WithPileContext_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSpecificContextExtensions._WithPileContext_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000318 RID: 792
			// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x0002CBE8 File Offset: 0x0002ADE8
			// (set) Token: 0x06000AC7 RID: 2759 RVA: 0x00007489 File Offset: 0x00005689
			public unsafe string __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSpecificContextExtensions._WithPileContext_d__1.NativeFieldInfoPtr___2__current);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSpecificContextExtensions._WithPileContext_d__1.NativeFieldInfoPtr___2__current), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000319 RID: 793
			// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x0002CC10 File Offset: 0x0002AE10
			// (set) Token: 0x06000AC9 RID: 2761 RVA: 0x000074A8 File Offset: 0x000056A8
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSpecificContextExtensions._WithPileContext_d__1.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSpecificContextExtensions._WithPileContext_d__1.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x040006B1 RID: 1713
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040006B2 RID: 1714
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040006B3 RID: 1715
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040006B4 RID: 1716
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040006B5 RID: 1717
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040006B6 RID: 1718
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040006B7 RID: 1719
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0;

			// Token: 0x040006B8 RID: 1720
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040006B9 RID: 1721
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040006BA RID: 1722
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0;

			// Token: 0x040006BB RID: 1723
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
