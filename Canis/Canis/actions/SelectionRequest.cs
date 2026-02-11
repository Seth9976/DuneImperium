using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Networking.selection.messages;

namespace Canis.actions
{
	// Token: 0x02000191 RID: 401
	public class SelectionRequest : Object
	{
		// Token: 0x0600118F RID: 4495 RVA: 0x00060974 File Offset: 0x0005EB74
		// Note: this type is marked as 'beforefieldinit'.
		static SelectionRequest()
		{
			Il2CppClassPointerStore<SelectionRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SelectionRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionRequest>.NativeClassPtr);
			SelectionRequest.NativeMethodInfoPtr_Match_Public_TResult_Func_2_AutoSelection_1_T_TResult_Func_2_RequestSelection_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRequest>.NativeClassPtr, 100666980);
			SelectionRequest.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRequest>.NativeClassPtr, 100666981);
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x000609CC File Offset: 0x0005EBCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 584201, RefRangeEnd = 584203, XrefRangeStart = 584177, XrefRangeEnd = 584201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TResult Match<T, TResult>(Func<SelectionRequest.AutoSelection<T>, TResult> handleAuto, Func<SelectionRequest.RequestSelection, TResult> handleRequest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handleAuto);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handleRequest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionRequest.MethodInfoStoreGeneric_Match_Public_TResult_Func_2_AutoSelection_1_T_TResult_Func_2_RequestSelection_TResult_0<T, TResult>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x00060A28 File Offset: 0x0005EC28
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionRequest.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x00008C01 File Offset: 0x00006E01
		public SelectionRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B85 RID: 2949
		private static readonly IntPtr NativeMethodInfoPtr_Match_Public_TResult_Func_2_AutoSelection_1_T_TResult_Func_2_RequestSelection_TResult_0;

		// Token: 0x04000B86 RID: 2950
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020003CB RID: 971
		public class IAutoSelection : Il2CppObjectBase
		{
			// Token: 0x06002917 RID: 10519 RVA: 0x00013AA3 File Offset: 0x00011CA3
			// Note: this type is marked as 'beforefieldinit'.
			static IAutoSelection()
			{
				Il2CppClassPointerStore<SelectionRequest.IAutoSelection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectionRequest>.NativeClassPtr, "IAutoSelection");
			}

			// Token: 0x06002918 RID: 10520 RVA: 0x00013AB9 File Offset: 0x00011CB9
			public IAutoSelection(IntPtr pointer)
				: base(pointer)
			{
			}
		}

		// Token: 0x020003CC RID: 972
		public class AutoSelection<T> : SelectionRequest
		{
			// Token: 0x06002919 RID: 10521 RVA: 0x000B1BEC File Offset: 0x000AFDEC
			// Note: this type is marked as 'beforefieldinit'.
			static AutoSelection()
			{
				Il2CppClassPointerStore<SelectionRequest.AutoSelection<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectionRequest>.NativeClassPtr, "AutoSelection`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionRequest.AutoSelection<T>>.NativeClassPtr);
				SelectionRequest.AutoSelection<T>.NativeFieldInfoPtr_AutoTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionRequest.AutoSelection<T>>.NativeClassPtr, "AutoTargets");
				SelectionRequest.AutoSelection<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRequest.AutoSelection<T>>.NativeClassPtr, 100666982);
				SelectionRequest.AutoSelection<T>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRequest.AutoSelection<T>>.NativeClassPtr, 100666983);
			}

			// Token: 0x0600291A RID: 10522 RVA: 0x000B1C90 File Offset: 0x000AFE90
			[CallerCount(96)]
			[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AutoSelection(IEnumerable<T> autoTargets)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionRequest.AutoSelection<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(autoTargets);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionRequest.AutoSelection<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600291B RID: 10523 RVA: 0x000B1CDC File Offset: 0x000AFEDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584154, XrefRangeEnd = 584156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionRequest.AutoSelection<T>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600291C RID: 10524 RVA: 0x00013AC2 File Offset: 0x00011CC2
			public AutoSelection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A58 RID: 2648
			// (get) Token: 0x0600291D RID: 10525 RVA: 0x000B1D20 File Offset: 0x000AFF20
			// (set) Token: 0x0600291E RID: 10526 RVA: 0x00013ACB File Offset: 0x00011CCB
			public unsafe IEnumerable<T> AutoTargets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionRequest.AutoSelection<T>.NativeFieldInfoPtr_AutoTargets);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionRequest.AutoSelection<T>.NativeFieldInfoPtr_AutoTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019AB RID: 6571
			private static readonly IntPtr NativeFieldInfoPtr_AutoTargets;

			// Token: 0x040019AC RID: 6572
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0;

			// Token: 0x040019AD RID: 6573
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
		}

		// Token: 0x020003CD RID: 973
		public class RequestSelection : SelectionRequest
		{
			// Token: 0x0600291F RID: 10527 RVA: 0x000B1D50 File Offset: 0x000AFF50
			// Note: this type is marked as 'beforefieldinit'.
			static RequestSelection()
			{
				Il2CppClassPointerStore<SelectionRequest.RequestSelection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectionRequest>.NativeClassPtr, "RequestSelection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionRequest.RequestSelection>.NativeClassPtr);
				SelectionRequest.RequestSelection.NativeFieldInfoPtr_Messages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionRequest.RequestSelection>.NativeClassPtr, "Messages");
				SelectionRequest.RequestSelection.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRequest.RequestSelection>.NativeClassPtr, 100666984);
				SelectionRequest.RequestSelection.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionRequest.RequestSelection>.NativeClassPtr, 100666985);
			}

			// Token: 0x06002920 RID: 10528 RVA: 0x000B1DB8 File Offset: 0x000AFFB8
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 584161, RefRangeEnd = 584170, XrefRangeStart = 584156, XrefRangeEnd = 584161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RequestSelection([Optional] Il2CppReferenceArray<SelectionMessage> messages)
			{
				if (messages == null)
				{
					messages = new Il2CppReferenceArray<SelectionMessage>(0L);
				}
				this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionRequest.RequestSelection>.NativeClassPtr));
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(messages);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionRequest.RequestSelection.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_SelectionMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002921 RID: 10529 RVA: 0x000B1E10 File Offset: 0x000B0010
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584170, XrefRangeEnd = 584177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionRequest.RequestSelection.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06002922 RID: 10530 RVA: 0x00013AEA File Offset: 0x00011CEA
			public RequestSelection(params SelectionMessage[] messages)
				: this(new Il2CppReferenceArray<SelectionMessage>(messages))
			{
			}

			// Token: 0x06002923 RID: 10531 RVA: 0x00013AF8 File Offset: 0x00011CF8
			public RequestSelection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A59 RID: 2649
			// (get) Token: 0x06002924 RID: 10532 RVA: 0x000B1E54 File Offset: 0x000B0054
			// (set) Token: 0x06002925 RID: 10533 RVA: 0x00013B01 File Offset: 0x00011D01
			public unsafe List<SelectionMessage> Messages
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionRequest.RequestSelection.NativeFieldInfoPtr_Messages);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SelectionMessage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionRequest.RequestSelection.NativeFieldInfoPtr_Messages), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019AE RID: 6574
			private static readonly IntPtr NativeFieldInfoPtr_Messages;

			// Token: 0x040019AF RID: 6575
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_SelectionMessage_0;

			// Token: 0x040019B0 RID: 6576
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
		}

		// Token: 0x020003CE RID: 974
		private sealed class MethodInfoStoreGeneric_Match_Public_TResult_Func_2_AutoSelection_1_T_TResult_Func_2_RequestSelection_TResult_0<T, TResult>
		{
			// Token: 0x040019B1 RID: 6577
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SelectionRequest.NativeMethodInfoPtr_Match_Public_TResult_Func_2_AutoSelection_1_T_TResult_Func_2_RequestSelection_TResult_0, Il2CppClassPointerStore<SelectionRequest>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			}))));
		}
	}
}
