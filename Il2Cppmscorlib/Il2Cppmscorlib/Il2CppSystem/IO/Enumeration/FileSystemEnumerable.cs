using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.IO.Enumeration
{
	// Token: 0x02000552 RID: 1362
	public class FileSystemEnumerable<TResult> : Object
	{
		// Token: 0x06005426 RID: 21542 RVA: 0x00187A5C File Offset: 0x00185C5C
		// Note: this type is marked as 'beforefieldinit'.
		static FileSystemEnumerable()
		{
			Il2CppClassPointerStore<FileSystemEnumerable<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO.Enumeration", "FileSystemEnumerable`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileSystemEnumerable<TResult>>.NativeClassPtr);
			FileSystemEnumerable<TResult>.NativeFieldInfoPtr__enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerable<TResult>>.NativeClassPtr, "_enumerator");
			FileSystemEnumerable<TResult>.NativeFieldInfoPtr__transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerable<TResult>>.NativeClassPtr, "_transform");
			FileSystemEnumerable<TResult>.NativeFieldInfoPtr__options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerable<TResult>>.NativeClassPtr, "_options");
			FileSystemEnumerable<TResult>.NativeFieldInfoPtr__directory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerable<TResult>>.NativeClassPtr, "_directory");
			FileSystemEnumerable<TResult>.NativeFieldInfoPtr__ShouldIncludePredicate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerable<TResult>>.NativeClassPtr, "<ShouldIncludePredicate>k__BackingField");
			FileSystemEnumerable<TResult>.NativeFieldInfoPtr__ShouldRecursePredicate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerable<TResult>>.NativeClassPtr, "<ShouldRecursePredicate>k__BackingField");
			FileSystemEnumerable<TResult>.NativeMethodInfoPtr__ctor_Public_Void_String_FindTransform_TResult_EnumerationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerable<TResult>>.NativeClassPtr, 100676207);
			FileSystemEnumerable<TResult>.NativeMethodInfoPtr_get_ShouldIncludePredicate_Public_get_FindPredicate_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerable<TResult>>.NativeClassPtr, 100676208);
			FileSystemEnumerable<TResult>.NativeMethodInfoPtr_set_ShouldIncludePredicate_Public_set_Void_FindPredicate_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerable<TResult>>.NativeClassPtr, 100676209);
			FileSystemEnumerable<TResult>.NativeMethodInfoPtr_get_ShouldRecursePredicate_Public_get_FindPredicate_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerable<TResult>>.NativeClassPtr, 100676210);
			FileSystemEnumerable<TResult>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerable<TResult>>.NativeClassPtr, 100676211);
			FileSystemEnumerable<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerable<TResult>>.NativeClassPtr, 100676212);
		}

		// Token: 0x06005427 RID: 21543 RVA: 0x00187BB8 File Offset: 0x00185DB8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1434890, RefRangeEnd = 1434896, XrefRangeStart = 1434867, XrefRangeEnd = 1434890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileSystemEnumerable(string directory, FileSystemEnumerable<TResult>.FindTransform transform, EnumerationOptions options = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileSystemEnumerable<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(directory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transform);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerable<TResult>.NativeMethodInfoPtr__ctor_Public_Void_String_FindTransform_TResult_EnumerationOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001564 RID: 5476
		// (get) Token: 0x06005428 RID: 21544 RVA: 0x00187C28 File Offset: 0x00185E28
		// (set) Token: 0x06005429 RID: 21545 RVA: 0x00187C68 File Offset: 0x00185E68
		public unsafe FileSystemEnumerable<TResult>.FindPredicate ShouldIncludePredicate
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerable<TResult>.NativeMethodInfoPtr_get_ShouldIncludePredicate_Public_get_FindPredicate_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FileSystemEnumerable<TResult>.FindPredicate>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerable<TResult>.NativeMethodInfoPtr_set_ShouldIncludePredicate_Public_set_Void_FindPredicate_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001565 RID: 5477
		// (get) Token: 0x0600542A RID: 21546 RVA: 0x00187CAC File Offset: 0x00185EAC
		public unsafe FileSystemEnumerable<TResult>.FindPredicate ShouldRecursePredicate
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerable<TResult>.NativeMethodInfoPtr_get_ShouldRecursePredicate_Public_get_FindPredicate_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FileSystemEnumerable<TResult>.FindPredicate>(intPtr3) : null;
			}
		}

		// Token: 0x0600542B RID: 21547 RVA: 0x00187CEC File Offset: 0x00185EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434896, XrefRangeEnd = 1434900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<TResult> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerable<TResult>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TResult>>(intPtr3) : null;
		}

		// Token: 0x0600542C RID: 21548 RVA: 0x00187D2C File Offset: 0x00185F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434900, XrefRangeEnd = 1434904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerable<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600542D RID: 21549 RVA: 0x0001DCD0 File Offset: 0x0001BED0
		public FileSystemEnumerable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700155E RID: 5470
		// (get) Token: 0x0600542E RID: 21550 RVA: 0x00187D6C File Offset: 0x00185F6C
		// (set) Token: 0x0600542F RID: 21551 RVA: 0x0001DCD9 File Offset: 0x0001BED9
		public unsafe FileSystemEnumerable<TResult>.DelegateEnumerator _enumerator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerable<TResult>.NativeFieldInfoPtr__enumerator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FileSystemEnumerable<TResult>.DelegateEnumerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerable<TResult>.NativeFieldInfoPtr__enumerator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700155F RID: 5471
		// (get) Token: 0x06005430 RID: 21552 RVA: 0x00187D9C File Offset: 0x00185F9C
		// (set) Token: 0x06005431 RID: 21553 RVA: 0x0001DCF8 File Offset: 0x0001BEF8
		public unsafe FileSystemEnumerable<TResult>.FindTransform _transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerable<TResult>.NativeFieldInfoPtr__transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FileSystemEnumerable<TResult>.FindTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerable<TResult>.NativeFieldInfoPtr__transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001560 RID: 5472
		// (get) Token: 0x06005432 RID: 21554 RVA: 0x00187DCC File Offset: 0x00185FCC
		// (set) Token: 0x06005433 RID: 21555 RVA: 0x0001DD17 File Offset: 0x0001BF17
		public unsafe EnumerationOptions _options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerable<TResult>.NativeFieldInfoPtr__options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnumerationOptions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerable<TResult>.NativeFieldInfoPtr__options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001561 RID: 5473
		// (get) Token: 0x06005434 RID: 21556 RVA: 0x00187DFC File Offset: 0x00185FFC
		// (set) Token: 0x06005435 RID: 21557 RVA: 0x0001DD36 File Offset: 0x0001BF36
		public unsafe string _directory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerable<TResult>.NativeFieldInfoPtr__directory);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerable<TResult>.NativeFieldInfoPtr__directory), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001562 RID: 5474
		// (get) Token: 0x06005436 RID: 21558 RVA: 0x00187E24 File Offset: 0x00186024
		// (set) Token: 0x06005437 RID: 21559 RVA: 0x0001DD55 File Offset: 0x0001BF55
		public unsafe FileSystemEnumerable<TResult>.FindPredicate _ShouldIncludePredicate_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerable<TResult>.NativeFieldInfoPtr__ShouldIncludePredicate_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FileSystemEnumerable<TResult>.FindPredicate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerable<TResult>.NativeFieldInfoPtr__ShouldIncludePredicate_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001563 RID: 5475
		// (get) Token: 0x06005438 RID: 21560 RVA: 0x00187E54 File Offset: 0x00186054
		// (set) Token: 0x06005439 RID: 21561 RVA: 0x0001DD74 File Offset: 0x0001BF74
		public unsafe FileSystemEnumerable<TResult>.FindPredicate _ShouldRecursePredicate_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerable<TResult>.NativeFieldInfoPtr__ShouldRecursePredicate_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FileSystemEnumerable<TResult>.FindPredicate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerable<TResult>.NativeFieldInfoPtr__ShouldRecursePredicate_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040044D1 RID: 17617
		private static readonly IntPtr NativeFieldInfoPtr__enumerator;

		// Token: 0x040044D2 RID: 17618
		private static readonly IntPtr NativeFieldInfoPtr__transform;

		// Token: 0x040044D3 RID: 17619
		private static readonly IntPtr NativeFieldInfoPtr__options;

		// Token: 0x040044D4 RID: 17620
		private static readonly IntPtr NativeFieldInfoPtr__directory;

		// Token: 0x040044D5 RID: 17621
		private static readonly IntPtr NativeFieldInfoPtr__ShouldIncludePredicate_k__BackingField;

		// Token: 0x040044D6 RID: 17622
		private static readonly IntPtr NativeFieldInfoPtr__ShouldRecursePredicate_k__BackingField;

		// Token: 0x040044D7 RID: 17623
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_FindTransform_TResult_EnumerationOptions_0;

		// Token: 0x040044D8 RID: 17624
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldIncludePredicate_Public_get_FindPredicate_TResult_0;

		// Token: 0x040044D9 RID: 17625
		private static readonly IntPtr NativeMethodInfoPtr_set_ShouldIncludePredicate_Public_set_Void_FindPredicate_TResult_0;

		// Token: 0x040044DA RID: 17626
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldRecursePredicate_Public_get_FindPredicate_TResult_0;

		// Token: 0x040044DB RID: 17627
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TResult_0;

		// Token: 0x040044DC RID: 17628
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0200072F RID: 1839
		public sealed class FindPredicate : MulticastDelegate
		{
			// Token: 0x06006208 RID: 25096 RVA: 0x001B7B34 File Offset: 0x001B5D34
			// Note: this type is marked as 'beforefieldinit'.
			static FindPredicate()
			{
				Il2CppClassPointerStore<FileSystemEnumerable<TResult>.FindPredicate>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FileSystemEnumerable<TResult>>.NativeClassPtr, "FindPredicate"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
				FileSystemEnumerable<TResult>.FindPredicate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerable<TResult>.FindPredicate>.NativeClassPtr, 100676213);
				FileSystemEnumerable<TResult>.FindPredicate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref_FileSystemEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerable<TResult>.FindPredicate>.NativeClassPtr, 100676214);
			}

			// Token: 0x06006209 RID: 25097 RVA: 0x001B7BB8 File Offset: 0x001B5DB8
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 863654, RefRangeEnd = 863669, XrefRangeStart = 863654, XrefRangeEnd = 863669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FindPredicate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileSystemEnumerable<TResult>.FindPredicate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerable<TResult>.FindPredicate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600620A RID: 25098 RVA: 0x001B7C14 File Offset: 0x001B5E14
			[CallerCount(0)]
			public unsafe bool Invoke(ref FileSystemEntry entry)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(entry);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerable<TResult>.FindPredicate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref_FileSystemEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600620B RID: 25099 RVA: 0x000244D1 File Offset: 0x000226D1
			public FindPredicate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04004F2E RID: 20270
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04004F2F RID: 20271
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref_FileSystemEntry_0;
		}

		// Token: 0x02000730 RID: 1840
		public sealed class FindTransform : MulticastDelegate
		{
			// Token: 0x0600620C RID: 25100 RVA: 0x001B7C64 File Offset: 0x001B5E64
			// Note: this type is marked as 'beforefieldinit'.
			static FindTransform()
			{
				Il2CppClassPointerStore<FileSystemEnumerable<TResult>.FindTransform>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FileSystemEnumerable<TResult>>.NativeClassPtr, "FindTransform"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
				FileSystemEnumerable<TResult>.FindTransform.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerable<TResult>.FindTransform>.NativeClassPtr, 100676215);
				FileSystemEnumerable<TResult>.FindTransform.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_byref_FileSystemEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerable<TResult>.FindTransform>.NativeClassPtr, 100676216);
			}

			// Token: 0x0600620D RID: 25101 RVA: 0x001B7CE8 File Offset: 0x001B5EE8
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1434850, RefRangeEnd = 1434856, XrefRangeStart = 1434846, XrefRangeEnd = 1434850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FindTransform(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileSystemEnumerable<TResult>.FindTransform>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerable<TResult>.FindTransform.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600620E RID: 25102 RVA: 0x001B7D44 File Offset: 0x001B5F44
			[CallerCount(0)]
			public unsafe TResult Invoke(ref FileSystemEntry entry)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(entry);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerable<TResult>.FindTransform.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_byref_FileSystemEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
				}
			}

			// Token: 0x0600620F RID: 25103 RVA: 0x000244DA File Offset: 0x000226DA
			public FindTransform(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04004F30 RID: 20272
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04004F31 RID: 20273
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_byref_FileSystemEntry_0;
		}

		// Token: 0x02000731 RID: 1841
		public sealed class DelegateEnumerator : FileSystemEnumerator<TResult>
		{
			// Token: 0x06006210 RID: 25104 RVA: 0x001B7D90 File Offset: 0x001B5F90
			// Note: this type is marked as 'beforefieldinit'.
			static DelegateEnumerator()
			{
				Il2CppClassPointerStore<FileSystemEnumerable<TResult>.DelegateEnumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FileSystemEnumerable<TResult>>.NativeClassPtr, "DelegateEnumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileSystemEnumerable<TResult>.DelegateEnumerator>.NativeClassPtr);
				FileSystemEnumerable<TResult>.DelegateEnumerator.NativeFieldInfoPtr__enumerable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemEnumerable<TResult>.DelegateEnumerator>.NativeClassPtr, "_enumerable");
				FileSystemEnumerable<TResult>.DelegateEnumerator.NativeMethodInfoPtr__ctor_Public_Void_FileSystemEnumerable_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerable<TResult>.DelegateEnumerator>.NativeClassPtr, 100676217);
				FileSystemEnumerable<TResult>.DelegateEnumerator.NativeMethodInfoPtr_TransformEntry_Protected_Virtual_TResult_byref_FileSystemEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerable<TResult>.DelegateEnumerator>.NativeClassPtr, 100676218);
				FileSystemEnumerable<TResult>.DelegateEnumerator.NativeMethodInfoPtr_ShouldRecurseIntoEntry_Protected_Virtual_Boolean_byref_FileSystemEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerable<TResult>.DelegateEnumerator>.NativeClassPtr, 100676219);
				FileSystemEnumerable<TResult>.DelegateEnumerator.NativeMethodInfoPtr_ShouldIncludeEntry_Protected_Virtual_Boolean_byref_FileSystemEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemEnumerable<TResult>.DelegateEnumerator>.NativeClassPtr, 100676220);
			}

			// Token: 0x06006211 RID: 25105 RVA: 0x001B7E5C File Offset: 0x001B605C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1434859, RefRangeEnd = 1434862, XrefRangeStart = 1434856, XrefRangeEnd = 1434859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DelegateEnumerator(FileSystemEnumerable<TResult> enumerable)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileSystemEnumerable<TResult>.DelegateEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumerable);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerable<TResult>.DelegateEnumerator.NativeMethodInfoPtr__ctor_Public_Void_FileSystemEnumerable_1_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006212 RID: 25106 RVA: 0x001B7EA8 File Offset: 0x001B60A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434862, XrefRangeEnd = 1434867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override TResult TransformEntry(ref FileSystemEntry entry)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(entry);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerable<TResult>.DelegateEnumerator.NativeMethodInfoPtr_TransformEntry_Protected_Virtual_TResult_byref_FileSystemEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
				}
			}

			// Token: 0x06006213 RID: 25107 RVA: 0x001B7EF4 File Offset: 0x001B60F4
			[CallerCount(0)]
			public unsafe override bool ShouldRecurseIntoEntry(ref FileSystemEntry entry)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(entry);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerable<TResult>.DelegateEnumerator.NativeMethodInfoPtr_ShouldRecurseIntoEntry_Protected_Virtual_Boolean_byref_FileSystemEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006214 RID: 25108 RVA: 0x001B7F44 File Offset: 0x001B6144
			[CallerCount(0)]
			public unsafe override bool ShouldIncludeEntry(ref FileSystemEntry entry)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(entry);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemEnumerable<TResult>.DelegateEnumerator.NativeMethodInfoPtr_ShouldIncludeEntry_Protected_Virtual_Boolean_byref_FileSystemEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006215 RID: 25109 RVA: 0x000244E3 File Offset: 0x000226E3
			public DelegateEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001978 RID: 6520
			// (get) Token: 0x06006216 RID: 25110 RVA: 0x001B7F94 File Offset: 0x001B6194
			// (set) Token: 0x06006217 RID: 25111 RVA: 0x000244EC File Offset: 0x000226EC
			public unsafe FileSystemEnumerable<TResult> _enumerable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerable<TResult>.DelegateEnumerator.NativeFieldInfoPtr__enumerable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FileSystemEnumerable<TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemEnumerable<TResult>.DelegateEnumerator.NativeFieldInfoPtr__enumerable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004F32 RID: 20274
			private static readonly IntPtr NativeFieldInfoPtr__enumerable;

			// Token: 0x04004F33 RID: 20275
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FileSystemEnumerable_1_TResult_0;

			// Token: 0x04004F34 RID: 20276
			private static readonly IntPtr NativeMethodInfoPtr_TransformEntry_Protected_Virtual_TResult_byref_FileSystemEntry_0;

			// Token: 0x04004F35 RID: 20277
			private static readonly IntPtr NativeMethodInfoPtr_ShouldRecurseIntoEntry_Protected_Virtual_Boolean_byref_FileSystemEntry_0;

			// Token: 0x04004F36 RID: 20278
			private static readonly IntPtr NativeMethodInfoPtr_ShouldIncludeEntry_Protected_Virtual_Boolean_byref_FileSystemEntry_0;
		}
	}
}
