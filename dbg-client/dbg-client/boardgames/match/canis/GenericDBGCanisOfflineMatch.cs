using System;
using Canis;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace boardgames.match.canis
{
	// Token: 0x0200027D RID: 637
	public class GenericDBGCanisOfflineMatch<T> : DBGCanisOfflineMatch where T : Match, new()
	{
		// Token: 0x06001DEF RID: 7663 RVA: 0x000815A8 File Offset: 0x0007F7A8
		// Note: this type is marked as 'beforefieldinit'.
		static GenericDBGCanisOfflineMatch()
		{
			Il2CppClassPointerStore<GenericDBGCanisOfflineMatch<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.canis", "GenericDBGCanisOfflineMatch`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericDBGCanisOfflineMatch<T>>.NativeClassPtr);
			GenericDBGCanisOfflineMatch<T>.NativeMethodInfoPtr_configure_Protected_Virtual_Final_Void_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDBGCanisOfflineMatch<T>>.NativeClassPtr, 100668205);
			GenericDBGCanisOfflineMatch<T>.NativeMethodInfoPtr_configurePlayers_Protected_Virtual_New_Void_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDBGCanisOfflineMatch<T>>.NativeClassPtr, 100668206);
			GenericDBGCanisOfflineMatch<T>.NativeMethodInfoPtr_Write_Protected_Virtual_Void_Object_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDBGCanisOfflineMatch<T>>.NativeClassPtr, 100668207);
			GenericDBGCanisOfflineMatch<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDBGCanisOfflineMatch<T>>.NativeClassPtr, 100668208);
		}

		// Token: 0x06001DF0 RID: 7664 RVA: 0x00081664 File Offset: 0x0007F864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537926, XrefRangeEnd = 537953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void configure(MatchInitData mid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDBGCanisOfflineMatch<T>.NativeMethodInfoPtr_configure_Protected_Virtual_Final_Void_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DF1 RID: 7665 RVA: 0x000816A8 File Offset: 0x0007F8A8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void configurePlayers(MatchInitData matchInitData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchInitData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericDBGCanisOfflineMatch<T>.NativeMethodInfoPtr_configurePlayers_Protected_Virtual_New_Void_MatchInitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DF2 RID: 7666 RVA: 0x000816F8 File Offset: 0x0007F8F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537953, XrefRangeEnd = 537975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(Object message, AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericDBGCanisOfflineMatch<T>.NativeMethodInfoPtr_Write_Protected_Virtual_Void_Object_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DF3 RID: 7667 RVA: 0x00081758 File Offset: 0x0007F958
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 537976, RefRangeEnd = 537977, XrefRangeStart = 537975, XrefRangeEnd = 537976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericDBGCanisOfflineMatch()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericDBGCanisOfflineMatch<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDBGCanisOfflineMatch<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x0000FD1B File Offset: 0x0000DF1B
		public GenericDBGCanisOfflineMatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040012EB RID: 4843
		private static readonly IntPtr NativeMethodInfoPtr_configure_Protected_Virtual_Final_Void_MatchInitData_0;

		// Token: 0x040012EC RID: 4844
		private static readonly IntPtr NativeMethodInfoPtr_configurePlayers_Protected_Virtual_New_Void_MatchInitData_0;

		// Token: 0x040012ED RID: 4845
		private static readonly IntPtr NativeMethodInfoPtr_Write_Protected_Virtual_Void_Object_AccountID_0;

		// Token: 0x040012EE RID: 4846
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000470 RID: 1136
		[ObfuscatedName("boardgames.match.canis.GenericDBGCanisOfflineMatch`1+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x060035D0 RID: 13776 RVA: 0x000C93FC File Offset: 0x000C75FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<GenericDBGCanisOfflineMatch<T>.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericDBGCanisOfflineMatch<T>>.NativeClassPtr, "<>c__DisplayClass2_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericDBGCanisOfflineMatch<T>.__c__DisplayClass2_0>.NativeClassPtr);
				GenericDBGCanisOfflineMatch<T>.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericDBGCanisOfflineMatch<T>.__c__DisplayClass2_0>.NativeClassPtr, "<>4__this");
				GenericDBGCanisOfflineMatch<T>.__c__DisplayClass2_0.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericDBGCanisOfflineMatch<T>.__c__DisplayClass2_0>.NativeClassPtr, "message");
				GenericDBGCanisOfflineMatch<T>.__c__DisplayClass2_0.NativeFieldInfoPtr_accountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericDBGCanisOfflineMatch<T>.__c__DisplayClass2_0>.NativeClassPtr, "accountID");
				GenericDBGCanisOfflineMatch<T>.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDBGCanisOfflineMatch<T>.__c__DisplayClass2_0>.NativeClassPtr, 100668209);
				GenericDBGCanisOfflineMatch<T>.__c__DisplayClass2_0.NativeMethodInfoPtr__Write_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericDBGCanisOfflineMatch<T>.__c__DisplayClass2_0>.NativeClassPtr, 100668210);
			}

			// Token: 0x060035D1 RID: 13777 RVA: 0x000C94C8 File Offset: 0x000C76C8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericDBGCanisOfflineMatch<T>.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDBGCanisOfflineMatch<T>.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060035D2 RID: 13778 RVA: 0x000C9504 File Offset: 0x000C7704
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537906, XrefRangeEnd = 537926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Write_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericDBGCanisOfflineMatch<T>.__c__DisplayClass2_0.NativeMethodInfoPtr__Write_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060035D3 RID: 13779 RVA: 0x0001BBCC File Offset: 0x00019DCC
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FCB RID: 4043
			// (get) Token: 0x060035D4 RID: 13780 RVA: 0x000C9538 File Offset: 0x000C7738
			// (set) Token: 0x060035D5 RID: 13781 RVA: 0x0001BBD5 File Offset: 0x00019DD5
			public unsafe GenericDBGCanisOfflineMatch<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDBGCanisOfflineMatch<T>.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericDBGCanisOfflineMatch<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDBGCanisOfflineMatch<T>.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FCC RID: 4044
			// (get) Token: 0x060035D6 RID: 13782 RVA: 0x000C9568 File Offset: 0x000C7768
			// (set) Token: 0x060035D7 RID: 13783 RVA: 0x0001BBF4 File Offset: 0x00019DF4
			public unsafe Object message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDBGCanisOfflineMatch<T>.__c__DisplayClass2_0.NativeFieldInfoPtr_message);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDBGCanisOfflineMatch<T>.__c__DisplayClass2_0.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FCD RID: 4045
			// (get) Token: 0x060035D8 RID: 13784 RVA: 0x000C9598 File Offset: 0x000C7798
			// (set) Token: 0x060035D9 RID: 13785 RVA: 0x0001BC13 File Offset: 0x00019E13
			public unsafe AccountID accountID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDBGCanisOfflineMatch<T>.__c__DisplayClass2_0.NativeFieldInfoPtr_accountID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericDBGCanisOfflineMatch<T>.__c__DisplayClass2_0.NativeFieldInfoPtr_accountID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002124 RID: 8484
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002125 RID: 8485
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x04002126 RID: 8486
			private static readonly IntPtr NativeFieldInfoPtr_accountID;

			// Token: 0x04002127 RID: 8487
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002128 RID: 8488
			private static readonly IntPtr NativeMethodInfoPtr__Write_b__0_Internal_Void_0;
		}
	}
}
