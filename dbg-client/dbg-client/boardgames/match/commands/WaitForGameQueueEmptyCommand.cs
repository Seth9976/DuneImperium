using System;
using boardgames.match.tutorial;
using dwd.core.commands;
using dwd.core.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using zen.match;

namespace boardgames.match.commands
{
	// Token: 0x02000295 RID: 661
	public class WaitForGameQueueEmptyCommand : Command
	{
		// Token: 0x06001F18 RID: 7960 RVA: 0x000854AC File Offset: 0x000836AC
		// Note: this type is marked as 'beforefieldinit'.
		static WaitForGameQueueEmptyCommand()
		{
			Il2CppClassPointerStore<WaitForGameQueueEmptyCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.commands", "WaitForGameQueueEmptyCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForGameQueueEmptyCommand>.NativeClassPtr);
			WaitForGameQueueEmptyCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForGameQueueEmptyCommand>.NativeClassPtr, 100668485);
			WaitForGameQueueEmptyCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForGameQueueEmptyCommand>.NativeClassPtr, 100668486);
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x00085504 File Offset: 0x00083704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540799, XrefRangeEnd = 540803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitForGameQueueEmptyCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x00085550 File Offset: 0x00083750
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 498694, RefRangeEnd = 498749, XrefRangeStart = 498694, XrefRangeEnd = 498749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitForGameQueueEmptyCommand()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForGameQueueEmptyCommand>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForGameQueueEmptyCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F1B RID: 7963 RVA: 0x000105AB File Offset: 0x0000E7AB
		public WaitForGameQueueEmptyCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040013A5 RID: 5029
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040013A6 RID: 5030
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000492 RID: 1170
		[ObfuscatedName("boardgames.match.commands.WaitForGameQueueEmptyCommand+<execute>d__0")]
		public sealed class _execute_d__0 : Object
		{
			// Token: 0x0600377A RID: 14202 RVA: 0x000CE474 File Offset: 0x000CC674
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__0()
			{
				Il2CppClassPointerStore<WaitForGameQueueEmptyCommand._execute_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WaitForGameQueueEmptyCommand>.NativeClassPtr, "<execute>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForGameQueueEmptyCommand._execute_d__0>.NativeClassPtr);
				WaitForGameQueueEmptyCommand._execute_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForGameQueueEmptyCommand._execute_d__0>.NativeClassPtr, "<>1__state");
				WaitForGameQueueEmptyCommand._execute_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForGameQueueEmptyCommand._execute_d__0>.NativeClassPtr, "<>2__current");
				WaitForGameQueueEmptyCommand._execute_d__0.NativeFieldInfoPtr__entitiesProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForGameQueueEmptyCommand._execute_d__0>.NativeClassPtr, "<entitiesProvider>5__2");
				WaitForGameQueueEmptyCommand._execute_d__0.NativeFieldInfoPtr__messageQueue_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForGameQueueEmptyCommand._execute_d__0>.NativeClassPtr, "<messageQueue>5__3");
				WaitForGameQueueEmptyCommand._execute_d__0.NativeFieldInfoPtr__commandQueue_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForGameQueueEmptyCommand._execute_d__0>.NativeClassPtr, "<commandQueue>5__4");
				WaitForGameQueueEmptyCommand._execute_d__0.NativeFieldInfoPtr__tutorial_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForGameQueueEmptyCommand._execute_d__0>.NativeClassPtr, "<tutorial>5__5");
				WaitForGameQueueEmptyCommand._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForGameQueueEmptyCommand._execute_d__0>.NativeClassPtr, 100668487);
				WaitForGameQueueEmptyCommand._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForGameQueueEmptyCommand._execute_d__0>.NativeClassPtr, 100668488);
				WaitForGameQueueEmptyCommand._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForGameQueueEmptyCommand._execute_d__0>.NativeClassPtr, 100668489);
				WaitForGameQueueEmptyCommand._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForGameQueueEmptyCommand._execute_d__0>.NativeClassPtr, 100668490);
				WaitForGameQueueEmptyCommand._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForGameQueueEmptyCommand._execute_d__0>.NativeClassPtr, 100668491);
				WaitForGameQueueEmptyCommand._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForGameQueueEmptyCommand._execute_d__0>.NativeClassPtr, 100668492);
			}

			// Token: 0x0600377B RID: 14203 RVA: 0x000CE590 File Offset: 0x000CC790
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForGameQueueEmptyCommand._execute_d__0>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForGameQueueEmptyCommand._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600377C RID: 14204 RVA: 0x000CE5D8 File Offset: 0x000CC7D8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForGameQueueEmptyCommand._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600377D RID: 14205 RVA: 0x000CE60C File Offset: 0x000CC80C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540790, XrefRangeEnd = 540794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForGameQueueEmptyCommand._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001061 RID: 4193
			// (get) Token: 0x0600377E RID: 14206 RVA: 0x000CE648 File Offset: 0x000CC848
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForGameQueueEmptyCommand._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600377F RID: 14207 RVA: 0x000CE688 File Offset: 0x000CC888
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540794, XrefRangeEnd = 540799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForGameQueueEmptyCommand._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001062 RID: 4194
			// (get) Token: 0x06003780 RID: 14208 RVA: 0x000CE6BC File Offset: 0x000CC8BC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForGameQueueEmptyCommand._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003781 RID: 14209 RVA: 0x0001C859 File Offset: 0x0001AA59
			public _execute_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700105B RID: 4187
			// (get) Token: 0x06003782 RID: 14210 RVA: 0x000CE6FC File Offset: 0x000CC8FC
			// (set) Token: 0x06003783 RID: 14211 RVA: 0x0001C862 File Offset: 0x0001AA62
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForGameQueueEmptyCommand._execute_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForGameQueueEmptyCommand._execute_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700105C RID: 4188
			// (get) Token: 0x06003784 RID: 14212 RVA: 0x000CE724 File Offset: 0x000CC924
			// (set) Token: 0x06003785 RID: 14213 RVA: 0x0001C87D File Offset: 0x0001AA7D
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForGameQueueEmptyCommand._execute_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForGameQueueEmptyCommand._execute_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700105D RID: 4189
			// (get) Token: 0x06003786 RID: 14214 RVA: 0x000CE754 File Offset: 0x000CC954
			// (set) Token: 0x06003787 RID: 14215 RVA: 0x0001C89C File Offset: 0x0001AA9C
			public unsafe EntitiesProvider _entitiesProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForGameQueueEmptyCommand._execute_d__0.NativeFieldInfoPtr__entitiesProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForGameQueueEmptyCommand._execute_d__0.NativeFieldInfoPtr__entitiesProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700105E RID: 4190
			// (get) Token: 0x06003788 RID: 14216 RVA: 0x000CE784 File Offset: 0x000CC984
			// (set) Token: 0x06003789 RID: 14217 RVA: 0x0001C8BB File Offset: 0x0001AABB
			public unsafe SimpleGameMessageQueue _messageQueue_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForGameQueueEmptyCommand._execute_d__0.NativeFieldInfoPtr__messageQueue_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleGameMessageQueue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForGameQueueEmptyCommand._execute_d__0.NativeFieldInfoPtr__messageQueue_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700105F RID: 4191
			// (get) Token: 0x0600378A RID: 14218 RVA: 0x000CE7B4 File Offset: 0x000CC9B4
			// (set) Token: 0x0600378B RID: 14219 RVA: 0x0001C8DA File Offset: 0x0001AADA
			public unsafe CommandQueue _commandQueue_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForGameQueueEmptyCommand._execute_d__0.NativeFieldInfoPtr__commandQueue_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CommandQueue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForGameQueueEmptyCommand._execute_d__0.NativeFieldInfoPtr__commandQueue_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001060 RID: 4192
			// (get) Token: 0x0600378C RID: 14220 RVA: 0x000CE7E4 File Offset: 0x000CC9E4
			// (set) Token: 0x0600378D RID: 14221 RVA: 0x0001C8F9 File Offset: 0x0001AAF9
			public unsafe TutorialEffects _tutorial_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForGameQueueEmptyCommand._execute_d__0.NativeFieldInfoPtr__tutorial_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialEffects>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForGameQueueEmptyCommand._execute_d__0.NativeFieldInfoPtr__tutorial_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002222 RID: 8738
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002223 RID: 8739
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002224 RID: 8740
			private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__2;

			// Token: 0x04002225 RID: 8741
			private static readonly IntPtr NativeFieldInfoPtr__messageQueue_5__3;

			// Token: 0x04002226 RID: 8742
			private static readonly IntPtr NativeFieldInfoPtr__commandQueue_5__4;

			// Token: 0x04002227 RID: 8743
			private static readonly IntPtr NativeFieldInfoPtr__tutorial_5__5;

			// Token: 0x04002228 RID: 8744
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002229 RID: 8745
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400222A RID: 8746
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400222B RID: 8747
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400222C RID: 8748
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400222D RID: 8749
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
