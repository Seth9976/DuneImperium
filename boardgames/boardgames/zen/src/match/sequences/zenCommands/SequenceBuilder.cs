using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace zen.src.match.sequences.zenCommands
{
	// Token: 0x02000067 RID: 103
	public class SequenceBuilder : global::Il2CppSystem.Object
	{
		// Token: 0x0600055A RID: 1370 RVA: 0x00020D94 File Offset: 0x0001EF94
		// Note: this type is marked as 'beforefieldinit'.
		static SequenceBuilder()
		{
			Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.match.sequences.zenCommands", "SequenceBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr);
			SequenceBuilder.NativeFieldInfoPtr_originalSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, "originalSequence");
			SequenceBuilder.NativeFieldInfoPtr_sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, "sequence");
			SequenceBuilder.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664069);
			SequenceBuilder.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664070);
			SequenceBuilder.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664071);
			SequenceBuilder.NativeMethodInfoPtr_runInSeries_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664072);
			SequenceBuilder.NativeMethodInfoPtr_Execute_Public_Coroutine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664073);
			SequenceBuilder.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664074);
			SequenceBuilder.NativeMethodInfoPtr_First_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664075);
			SequenceBuilder.NativeMethodInfoPtr_All_Public_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664076);
			SequenceBuilder.NativeMethodInfoPtr_Prepend_Public_SequenceBuilder_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664077);
			SequenceBuilder.NativeMethodInfoPtr_Append_Public_SequenceBuilder_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664078);
			SequenceBuilder.NativeMethodInfoPtr_Prepend_Public_SequenceBuilder_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664079);
			SequenceBuilder.NativeMethodInfoPtr_Append_Public_SequenceBuilder_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664080);
			SequenceBuilder.NativeMethodInfoPtr_WrapEverything_Public_SequenceBuilder_Func_2_IEnumerable_1_Command_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664081);
			SequenceBuilder.NativeMethodInfoPtr_Wrap_Private_SequenceBuilder_Func_2_Command_IEnumerator_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664082);
			SequenceBuilder.NativeMethodInfoPtr_WrapAll_Public_SequenceBuilder_Func_2_Command_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664083);
			SequenceBuilder.NativeMethodInfoPtr_WrapAll_Public_SequenceBuilder_Func_2_T_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664084);
			SequenceBuilder.NativeMethodInfoPtr_WrapFirst_Public_SequenceBuilder_Func_2_Command_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664085);
			SequenceBuilder.NativeMethodInfoPtr_WrapFirst_Public_SequenceBuilder_Func_2_T_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664086);
			SequenceBuilder.NativeMethodInfoPtr_WrapLast_Public_SequenceBuilder_Func_2_Command_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664087);
			SequenceBuilder.NativeMethodInfoPtr_WrapLast_Public_SequenceBuilder_Func_2_T_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664088);
			SequenceBuilder.NativeMethodInfoPtr_SortBy_Public_SequenceBuilder_Func_2_Command_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664089);
			SequenceBuilder.NativeMethodInfoPtr_SortByDescending_Public_SequenceBuilder_Func_2_Command_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664090);
			SequenceBuilder.NativeMethodInfoPtr_Bookend_Private_SequenceBuilder_Func_2_Command_IEnumerator_Func_2_Command_Boolean_Func_2_Command_IEnumerator_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664091);
			SequenceBuilder.NativeMethodInfoPtr_BookendAll_Private_SequenceBuilder_Func_2_Command_IEnumerator_Func_2_Command_Boolean_Func_2_Command_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664092);
			SequenceBuilder.NativeMethodInfoPtr_BookendAll_Public_SequenceBuilder_Func_1_IEnumerator_Func_2_Command_Boolean_Func_1_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664093);
			SequenceBuilder.NativeMethodInfoPtr_BookendAll_Public_SequenceBuilder_Func_2_Command_IEnumerator_Func_2_Command_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664094);
			SequenceBuilder.NativeMethodInfoPtr_BookendAll_Public_SequenceBuilder_Func_1_IEnumerator_Func_1_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664095);
			SequenceBuilder.NativeMethodInfoPtr_BookendFirst_Private_SequenceBuilder_Func_2_Command_IEnumerator_Func_2_Command_Boolean_Func_2_Command_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664096);
			SequenceBuilder.NativeMethodInfoPtr_BookendFirst_Public_SequenceBuilder_Func_1_IEnumerator_Func_2_Command_Boolean_Func_1_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664097);
			SequenceBuilder.NativeMethodInfoPtr_BookendFirst_Public_SequenceBuilder_Func_2_T_IEnumerator_Func_2_T_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664098);
			SequenceBuilder.NativeMethodInfoPtr_BookendFirst_Public_SequenceBuilder_Func_1_IEnumerator_Func_1_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664099);
			SequenceBuilder.NativeMethodInfoPtr_AddAfterAll_Public_SequenceBuilder_Func_2_Command_Boolean_Func_2_Command_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664100);
			SequenceBuilder.NativeMethodInfoPtr_AddAfterAll_Public_SequenceBuilder_Func_1_IEnumerator_Func_2_Command_Boolean_Func_1_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664101);
			SequenceBuilder.NativeMethodInfoPtr_AddAfterAll_Public_SequenceBuilder_Func_2_T_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664102);
			SequenceBuilder.NativeMethodInfoPtr_AddAfterAll_Public_SequenceBuilder_Func_1_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664103);
			SequenceBuilder.NativeMethodInfoPtr_AddAfterFirst_Public_SequenceBuilder_Func_2_Command_Boolean_Func_2_Command_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664104);
			SequenceBuilder.NativeMethodInfoPtr_AddAfterFirst_Public_SequenceBuilder_Func_2_Command_Boolean_Func_1_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664105);
			SequenceBuilder.NativeMethodInfoPtr_AddAfterFirst_Public_SequenceBuilder_Func_2_T_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664106);
			SequenceBuilder.NativeMethodInfoPtr_AddAfterFirst_Public_SequenceBuilder_Func_1_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664107);
			SequenceBuilder.NativeMethodInfoPtr_AddBeforeAll_Public_SequenceBuilder_Func_2_Command_IEnumerator_Func_2_Command_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664108);
			SequenceBuilder.NativeMethodInfoPtr_AddBeforeAll_Public_SequenceBuilder_Func_1_IEnumerator_Func_2_Command_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664109);
			SequenceBuilder.NativeMethodInfoPtr_AddBeforeAll_Public_SequenceBuilder_Func_2_T_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664110);
			SequenceBuilder.NativeMethodInfoPtr_AddBeforeAll_Public_SequenceBuilder_Func_1_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, 100664111);
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00021148 File Offset: 0x0001F348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987265, XrefRangeEnd = 987284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder(IEnumerable<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00021194 File Offset: 0x0001F394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987284, XrefRangeEnd = 987290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<Command> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Command>>(intPtr3) : null;
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x000211D4 File Offset: 0x0001F3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987290, XrefRangeEnd = 987296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00021214 File Offset: 0x0001F414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987296, XrefRangeEnd = 987301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator runInSeries()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.NativeMethodInfoPtr_runInSeries_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00021254 File Offset: 0x0001F454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987301, XrefRangeEnd = 987307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coroutine Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.NativeMethodInfoPtr_Execute_Public_Coroutine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00021294 File Offset: 0x0001F494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987307, XrefRangeEnd = 987331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SequenceBuilder.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x000212D8 File Offset: 0x0001F4D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987331, XrefRangeEnd = 987346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T First<T>() where T : Command
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.MethodInfoStoreGeneric_First_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00021314 File Offset: 0x0001F514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987346, XrefRangeEnd = 987348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<T> All<T>() where T : Command
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.MethodInfoStoreGeneric_All_Public_IEnumerable_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00021354 File Offset: 0x0001F554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987348, XrefRangeEnd = 987352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder Prepend(IEnumerator command)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.NativeMethodInfoPtr_Prepend_Public_SequenceBuilder_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x000213A4 File Offset: 0x0001F5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987352, XrefRangeEnd = 987356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder Append(IEnumerator command)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.NativeMethodInfoPtr_Append_Public_SequenceBuilder_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x000213F4 File Offset: 0x0001F5F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987356, XrefRangeEnd = 987363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder Prepend(Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.NativeMethodInfoPtr_Prepend_Public_SequenceBuilder_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00021444 File Offset: 0x0001F644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987363, XrefRangeEnd = 987372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder Append(Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.NativeMethodInfoPtr_Append_Public_SequenceBuilder_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00021494 File Offset: 0x0001F694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987372, XrefRangeEnd = 987385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder WrapEverything(Func<IEnumerable<Command>, IEnumerator> wrapperBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wrapperBuilder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.NativeMethodInfoPtr_WrapEverything_Public_SequenceBuilder_Func_2_IEnumerable_1_Command_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x000214E4 File Offset: 0x0001F6E4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 987418, RefRangeEnd = 987424, XrefRangeStart = 987385, XrefRangeEnd = 987418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder Wrap(Func<Command, IEnumerator> replaceWith, bool all, bool reverse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(replaceWith);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref all;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reverse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.NativeMethodInfoPtr_Wrap_Private_SequenceBuilder_Func_2_Command_IEnumerator_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00021550 File Offset: 0x0001F750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987424, XrefRangeEnd = 987425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder WrapAll(Func<Command, IEnumerator> replaceWith)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(replaceWith);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.NativeMethodInfoPtr_WrapAll_Public_SequenceBuilder_Func_2_Command_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x000215A0 File Offset: 0x0001F7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987425, XrefRangeEnd = 987435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder WrapAll<T>(Func<T, Command> replaceWith) where T : Command
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(replaceWith);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.MethodInfoStoreGeneric_WrapAll_Public_SequenceBuilder_Func_2_T_Command_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x000215F0 File Offset: 0x0001F7F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987435, XrefRangeEnd = 987436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder WrapFirst(Func<Command, IEnumerator> replaceWith)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(replaceWith);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.NativeMethodInfoPtr_WrapFirst_Public_SequenceBuilder_Func_2_Command_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00021640 File Offset: 0x0001F840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987436, XrefRangeEnd = 987446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder WrapFirst<T>(Func<T, Command> replaceWith) where T : Command
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(replaceWith);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.MethodInfoStoreGeneric_WrapFirst_Public_SequenceBuilder_Func_2_T_Command_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00021690 File Offset: 0x0001F890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987446, XrefRangeEnd = 987447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder WrapLast(Func<Command, IEnumerator> replaceWith)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(replaceWith);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.NativeMethodInfoPtr_WrapLast_Public_SequenceBuilder_Func_2_Command_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x000216E0 File Offset: 0x0001F8E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987447, XrefRangeEnd = 987457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder WrapLast<T>(Func<T, Command> replaceWith) where T : Command
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(replaceWith);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.MethodInfoStoreGeneric_WrapLast_Public_SequenceBuilder_Func_2_T_Command_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00021730 File Offset: 0x0001F930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987457, XrefRangeEnd = 987467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder SortBy(Func<Command, int> sortingFunction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sortingFunction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.NativeMethodInfoPtr_SortBy_Public_SequenceBuilder_Func_2_Command_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00021780 File Offset: 0x0001F980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987467, XrefRangeEnd = 987477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder SortByDescending(Func<Command, int> sortingFunction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sortingFunction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.NativeMethodInfoPtr_SortByDescending_Public_SequenceBuilder_Func_2_Command_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x000217D0 File Offset: 0x0001F9D0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 987515, RefRangeEnd = 987529, XrefRangeStart = 987477, XrefRangeEnd = 987515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder Bookend(Func<Command, IEnumerator> beforeCommandBuilder, Func<Command, bool> predicate, Func<Command, IEnumerator> afterCommandBuilder, bool all, bool reverse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(beforeCommandBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterCommandBuilder);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref all;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reverse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.NativeMethodInfoPtr_Bookend_Private_SequenceBuilder_Func_2_Command_IEnumerator_Func_2_Command_Boolean_Func_2_Command_IEnumerator_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00021860 File Offset: 0x0001FA60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987529, XrefRangeEnd = 987530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder BookendAll(Func<Command, IEnumerator> beforeCommandBuilder, Func<Command, bool> predicate, Func<Command, IEnumerator> afterCommandBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(beforeCommandBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterCommandBuilder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.NativeMethodInfoPtr_BookendAll_Private_SequenceBuilder_Func_2_Command_IEnumerator_Func_2_Command_Boolean_Func_2_Command_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x000218D4 File Offset: 0x0001FAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987530, XrefRangeEnd = 987548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder BookendAll(Func<IEnumerator> beforeCommandBuilder, Func<Command, bool> predicate, Func<IEnumerator> afterCommandBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(beforeCommandBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterCommandBuilder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.NativeMethodInfoPtr_BookendAll_Public_SequenceBuilder_Func_1_IEnumerator_Func_2_Command_Boolean_Func_1_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00021948 File Offset: 0x0001FB48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987548, XrefRangeEnd = 987563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder BookendAll<T>(Func<Command, IEnumerator> beforeCommandBuilder, Func<Command, IEnumerator> afterCommandBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(beforeCommandBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterCommandBuilder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.MethodInfoStoreGeneric_BookendAll_Public_SequenceBuilder_Func_2_Command_IEnumerator_Func_2_Command_IEnumerator_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x000219AC File Offset: 0x0001FBAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987563, XrefRangeEnd = 987589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder BookendAll<T>(Func<IEnumerator> beforeCommandBuilder, Func<IEnumerator> afterCommandBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(beforeCommandBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterCommandBuilder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.MethodInfoStoreGeneric_BookendAll_Public_SequenceBuilder_Func_1_IEnumerator_Func_1_IEnumerator_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00021A10 File Offset: 0x0001FC10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987589, XrefRangeEnd = 987590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder BookendFirst(Func<Command, IEnumerator> beforeCommandBuilder, Func<Command, bool> predicate, Func<Command, IEnumerator> afterCommandBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(beforeCommandBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterCommandBuilder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.NativeMethodInfoPtr_BookendFirst_Private_SequenceBuilder_Func_2_Command_IEnumerator_Func_2_Command_Boolean_Func_2_Command_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00021A84 File Offset: 0x0001FC84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987590, XrefRangeEnd = 987608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder BookendFirst(Func<IEnumerator> beforeCommandBuilder, Func<Command, bool> predicate, Func<IEnumerator> afterCommandBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(beforeCommandBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterCommandBuilder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.NativeMethodInfoPtr_BookendFirst_Public_SequenceBuilder_Func_1_IEnumerator_Func_2_Command_Boolean_Func_1_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00021AF8 File Offset: 0x0001FCF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 987635, RefRangeEnd = 987636, XrefRangeStart = 987608, XrefRangeEnd = 987635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder BookendFirst<T>(Func<T, IEnumerator> beforeCommandBuilder, Func<T, IEnumerator> afterCommandBuilder) where T : Command
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(beforeCommandBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterCommandBuilder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.MethodInfoStoreGeneric_BookendFirst_Public_SequenceBuilder_Func_2_T_IEnumerator_Func_2_T_IEnumerator_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00021B5C File Offset: 0x0001FD5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987636, XrefRangeEnd = 987662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder BookendFirst<T>(Func<IEnumerator> beforeCommandBuilder, Func<IEnumerator> afterCommandBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(beforeCommandBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterCommandBuilder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.MethodInfoStoreGeneric_BookendFirst_Public_SequenceBuilder_Func_1_IEnumerator_Func_1_IEnumerator_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00021BC0 File Offset: 0x0001FDC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 987678, RefRangeEnd = 987680, XrefRangeStart = 987662, XrefRangeEnd = 987678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder AddAfterAll(Func<Command, bool> predicate, Func<Command, IEnumerator> afterCommandBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterCommandBuilder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.NativeMethodInfoPtr_AddAfterAll_Public_SequenceBuilder_Func_2_Command_Boolean_Func_2_Command_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00021C24 File Offset: 0x0001FE24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987680, XrefRangeEnd = 987707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder AddAfterAll(Func<IEnumerator> beforeCommandBuilder, Func<Command, bool> predicate, Func<IEnumerator> afterCommandBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(beforeCommandBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterCommandBuilder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.NativeMethodInfoPtr_AddAfterAll_Public_SequenceBuilder_Func_1_IEnumerator_Func_2_Command_Boolean_Func_1_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00021C98 File Offset: 0x0001FE98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987707, XrefRangeEnd = 987731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder AddAfterAll<T>(Func<T, IEnumerator> afterCommandBuilder) where T : Command
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(afterCommandBuilder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.MethodInfoStoreGeneric_AddAfterAll_Public_SequenceBuilder_Func_2_T_IEnumerator_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00021CE8 File Offset: 0x0001FEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987731, XrefRangeEnd = 987754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder AddAfterAll<T>(Func<IEnumerator> afterCommandBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(afterCommandBuilder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.MethodInfoStoreGeneric_AddAfterAll_Public_SequenceBuilder_Func_1_IEnumerator_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00021D38 File Offset: 0x0001FF38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 987770, RefRangeEnd = 987771, XrefRangeStart = 987754, XrefRangeEnd = 987770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder AddAfterFirst(Func<Command, bool> predicate, Func<Command, IEnumerator> afterCommandBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterCommandBuilder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.NativeMethodInfoPtr_AddAfterFirst_Public_SequenceBuilder_Func_2_Command_Boolean_Func_2_Command_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00021D9C File Offset: 0x0001FF9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987771, XrefRangeEnd = 987798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder AddAfterFirst(Func<Command, bool> predicate, Func<IEnumerator> afterCommandBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterCommandBuilder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.NativeMethodInfoPtr_AddAfterFirst_Public_SequenceBuilder_Func_2_Command_Boolean_Func_1_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00021E00 File Offset: 0x00020000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987798, XrefRangeEnd = 987813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder AddAfterFirst<T>(Func<T, IEnumerator> afterCommandBuilder) where T : Command
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(afterCommandBuilder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.MethodInfoStoreGeneric_AddAfterFirst_Public_SequenceBuilder_Func_2_T_IEnumerator_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00021E50 File Offset: 0x00020050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987813, XrefRangeEnd = 987836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder AddAfterFirst<T>(Func<IEnumerator> afterCommandBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(afterCommandBuilder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.MethodInfoStoreGeneric_AddAfterFirst_Public_SequenceBuilder_Func_1_IEnumerator_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00021EA0 File Offset: 0x000200A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 987852, RefRangeEnd = 987854, XrefRangeStart = 987836, XrefRangeEnd = 987852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder AddBeforeAll(Func<Command, IEnumerator> beforeCommandBuilder, Func<Command, bool> predicate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(beforeCommandBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.NativeMethodInfoPtr_AddBeforeAll_Public_SequenceBuilder_Func_2_Command_IEnumerator_Func_2_Command_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00021F04 File Offset: 0x00020104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987854, XrefRangeEnd = 987881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder AddBeforeAll(Func<IEnumerator> beforeCommandBuilder, Func<Command, bool> predicate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(beforeCommandBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.NativeMethodInfoPtr_AddBeforeAll_Public_SequenceBuilder_Func_1_IEnumerator_Func_2_Command_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00021F68 File Offset: 0x00020168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987881, XrefRangeEnd = 987905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder AddBeforeAll<T>(Func<T, IEnumerator> beforeCommandBuilder) where T : Command
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(beforeCommandBuilder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.MethodInfoStoreGeneric_AddBeforeAll_Public_SequenceBuilder_Func_2_T_IEnumerator_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00021FB8 File Offset: 0x000201B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987905, XrefRangeEnd = 987928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceBuilder AddBeforeAll<T>(Func<IEnumerator> beforeCommandBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(beforeCommandBuilder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.MethodInfoStoreGeneric_AddBeforeAll_Public_SequenceBuilder_Func_1_IEnumerator_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x0000481B File Offset: 0x00002A1B
		public SequenceBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x00022008 File Offset: 0x00020208
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x00004824 File Offset: 0x00002A24
		public unsafe List<Command> originalSequence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.NativeFieldInfoPtr_originalSequence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Command>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.NativeFieldInfoPtr_originalSequence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x00022038 File Offset: 0x00020238
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x00004843 File Offset: 0x00002A43
		public unsafe List<Command> sequence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.NativeFieldInfoPtr_sequence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Command>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.NativeFieldInfoPtr_sequence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeFieldInfoPtr_originalSequence;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeFieldInfoPtr_sequence;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Command_0;

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_Command_0;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeMethodInfoPtr_runInSeries_Private_IEnumerator_0;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Coroutine_0;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr_First_Public_T_0;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr_All_Public_IEnumerable_1_T_0;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeMethodInfoPtr_Prepend_Public_SequenceBuilder_IEnumerator_0;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_SequenceBuilder_IEnumerator_0;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeMethodInfoPtr_Prepend_Public_SequenceBuilder_Action_0;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_SequenceBuilder_Action_0;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeMethodInfoPtr_WrapEverything_Public_SequenceBuilder_Func_2_IEnumerable_1_Command_IEnumerator_0;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeMethodInfoPtr_Wrap_Private_SequenceBuilder_Func_2_Command_IEnumerator_Boolean_Boolean_0;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeMethodInfoPtr_WrapAll_Public_SequenceBuilder_Func_2_Command_IEnumerator_0;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeMethodInfoPtr_WrapAll_Public_SequenceBuilder_Func_2_T_Command_0;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeMethodInfoPtr_WrapFirst_Public_SequenceBuilder_Func_2_Command_IEnumerator_0;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeMethodInfoPtr_WrapFirst_Public_SequenceBuilder_Func_2_T_Command_0;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr_WrapLast_Public_SequenceBuilder_Func_2_Command_IEnumerator_0;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeMethodInfoPtr_WrapLast_Public_SequenceBuilder_Func_2_T_Command_0;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr_SortBy_Public_SequenceBuilder_Func_2_Command_Int32_0;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeMethodInfoPtr_SortByDescending_Public_SequenceBuilder_Func_2_Command_Int32_0;

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeMethodInfoPtr_Bookend_Private_SequenceBuilder_Func_2_Command_IEnumerator_Func_2_Command_Boolean_Func_2_Command_IEnumerator_Boolean_Boolean_0;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeMethodInfoPtr_BookendAll_Private_SequenceBuilder_Func_2_Command_IEnumerator_Func_2_Command_Boolean_Func_2_Command_IEnumerator_0;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeMethodInfoPtr_BookendAll_Public_SequenceBuilder_Func_1_IEnumerator_Func_2_Command_Boolean_Func_1_IEnumerator_0;

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeMethodInfoPtr_BookendAll_Public_SequenceBuilder_Func_2_Command_IEnumerator_Func_2_Command_IEnumerator_0;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeMethodInfoPtr_BookendAll_Public_SequenceBuilder_Func_1_IEnumerator_Func_1_IEnumerator_0;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeMethodInfoPtr_BookendFirst_Private_SequenceBuilder_Func_2_Command_IEnumerator_Func_2_Command_Boolean_Func_2_Command_IEnumerator_0;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeMethodInfoPtr_BookendFirst_Public_SequenceBuilder_Func_1_IEnumerator_Func_2_Command_Boolean_Func_1_IEnumerator_0;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeMethodInfoPtr_BookendFirst_Public_SequenceBuilder_Func_2_T_IEnumerator_Func_2_T_IEnumerator_0;

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeMethodInfoPtr_BookendFirst_Public_SequenceBuilder_Func_1_IEnumerator_Func_1_IEnumerator_0;

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeMethodInfoPtr_AddAfterAll_Public_SequenceBuilder_Func_2_Command_Boolean_Func_2_Command_IEnumerator_0;

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeMethodInfoPtr_AddAfterAll_Public_SequenceBuilder_Func_1_IEnumerator_Func_2_Command_Boolean_Func_1_IEnumerator_0;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeMethodInfoPtr_AddAfterAll_Public_SequenceBuilder_Func_2_T_IEnumerator_0;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeMethodInfoPtr_AddAfterAll_Public_SequenceBuilder_Func_1_IEnumerator_0;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeMethodInfoPtr_AddAfterFirst_Public_SequenceBuilder_Func_2_Command_Boolean_Func_2_Command_IEnumerator_0;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeMethodInfoPtr_AddAfterFirst_Public_SequenceBuilder_Func_2_Command_Boolean_Func_1_IEnumerator_0;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeMethodInfoPtr_AddAfterFirst_Public_SequenceBuilder_Func_2_T_IEnumerator_0;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeMethodInfoPtr_AddAfterFirst_Public_SequenceBuilder_Func_1_IEnumerator_0;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeMethodInfoPtr_AddBeforeAll_Public_SequenceBuilder_Func_2_Command_IEnumerator_Func_2_Command_Boolean_0;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeMethodInfoPtr_AddBeforeAll_Public_SequenceBuilder_Func_1_IEnumerator_Func_2_Command_Boolean_0;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeMethodInfoPtr_AddBeforeAll_Public_SequenceBuilder_Func_2_T_IEnumerator_0;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeMethodInfoPtr_AddBeforeAll_Public_SequenceBuilder_Func_1_IEnumerator_0;

		// Token: 0x020001D7 RID: 471
		[ObfuscatedName("zen.src.match.sequences.zenCommands.SequenceBuilder+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06001678 RID: 5752 RVA: 0x00056724 File Offset: 0x00054924
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SequenceBuilder.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceBuilder.__c>.NativeClassPtr);
				SequenceBuilder.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c>.NativeClassPtr, "<>9");
				SequenceBuilder.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c>.NativeClassPtr, "<>9__7_0");
				SequenceBuilder.__c.NativeFieldInfoPtr___9__33_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c>.NativeClassPtr, "<>9__33_0");
				SequenceBuilder.__c.NativeFieldInfoPtr___9__37_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c>.NativeClassPtr, "<>9__37_0");
				SequenceBuilder.__c.NativeFieldInfoPtr___9__41_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c>.NativeClassPtr, "<>9__41_0");
				SequenceBuilder.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c>.NativeClassPtr, 100664113);
				SequenceBuilder.__c.NativeMethodInfoPtr__ToString_b__7_0_Internal_String_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c>.NativeClassPtr, 100664114);
				SequenceBuilder.__c.NativeMethodInfoPtr__AddAfterAll_b__33_0_Internal_IEnumerator_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c>.NativeClassPtr, 100664115);
				SequenceBuilder.__c.NativeMethodInfoPtr__AddAfterFirst_b__37_0_Internal_IEnumerator_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c>.NativeClassPtr, 100664116);
				SequenceBuilder.__c.NativeMethodInfoPtr__AddBeforeAll_b__41_0_Internal_IEnumerator_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c>.NativeClassPtr, 100664117);
			}

			// Token: 0x06001679 RID: 5753 RVA: 0x00056818 File Offset: 0x00054A18
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceBuilder.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600167A RID: 5754 RVA: 0x00056854 File Offset: 0x00054A54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987202, XrefRangeEnd = 987204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToString_b__7_0(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c.NativeMethodInfoPtr__ToString_b__7_0_Internal_String_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600167B RID: 5755 RVA: 0x0005689C File Offset: 0x00054A9C
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _AddAfterAll_b__33_0(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c.NativeMethodInfoPtr__AddAfterAll_b__33_0_Internal_IEnumerator_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x0600167C RID: 5756 RVA: 0x000568EC File Offset: 0x00054AEC
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _AddAfterFirst_b__37_0(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c.NativeMethodInfoPtr__AddAfterFirst_b__37_0_Internal_IEnumerator_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x0600167D RID: 5757 RVA: 0x0005693C File Offset: 0x00054B3C
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _AddBeforeAll_b__41_0(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c.NativeMethodInfoPtr__AddBeforeAll_b__41_0_Internal_IEnumerator_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x0600167E RID: 5758 RVA: 0x0000C833 File Offset: 0x0000AA33
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700067B RID: 1659
			// (get) Token: 0x0600167F RID: 5759 RVA: 0x0005698C File Offset: 0x00054B8C
			// (set) Token: 0x06001680 RID: 5760 RVA: 0x0000C83C File Offset: 0x0000AA3C
			public unsafe static SequenceBuilder.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequenceBuilder.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceBuilder.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequenceBuilder.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700067C RID: 1660
			// (get) Token: 0x06001681 RID: 5761 RVA: 0x000569B4 File Offset: 0x00054BB4
			// (set) Token: 0x06001682 RID: 5762 RVA: 0x0000C84E File Offset: 0x0000AA4E
			public unsafe static Func<Command, string> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequenceBuilder.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Command, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequenceBuilder.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700067D RID: 1661
			// (get) Token: 0x06001683 RID: 5763 RVA: 0x000569DC File Offset: 0x00054BDC
			// (set) Token: 0x06001684 RID: 5764 RVA: 0x0000C860 File Offset: 0x0000AA60
			public unsafe static Func<Command, IEnumerator> __9__33_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequenceBuilder.__c.NativeFieldInfoPtr___9__33_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Command, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequenceBuilder.__c.NativeFieldInfoPtr___9__33_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700067E RID: 1662
			// (get) Token: 0x06001685 RID: 5765 RVA: 0x00056A04 File Offset: 0x00054C04
			// (set) Token: 0x06001686 RID: 5766 RVA: 0x0000C872 File Offset: 0x0000AA72
			public unsafe static Func<Command, IEnumerator> __9__37_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequenceBuilder.__c.NativeFieldInfoPtr___9__37_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Command, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequenceBuilder.__c.NativeFieldInfoPtr___9__37_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700067F RID: 1663
			// (get) Token: 0x06001687 RID: 5767 RVA: 0x00056A2C File Offset: 0x00054C2C
			// (set) Token: 0x06001688 RID: 5768 RVA: 0x0000C884 File Offset: 0x0000AA84
			public unsafe static Func<Command, IEnumerator> __9__41_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequenceBuilder.__c.NativeFieldInfoPtr___9__41_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Command, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequenceBuilder.__c.NativeFieldInfoPtr___9__41_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DA5 RID: 3493
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000DA6 RID: 3494
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04000DA7 RID: 3495
			private static readonly IntPtr NativeFieldInfoPtr___9__33_0;

			// Token: 0x04000DA8 RID: 3496
			private static readonly IntPtr NativeFieldInfoPtr___9__37_0;

			// Token: 0x04000DA9 RID: 3497
			private static readonly IntPtr NativeFieldInfoPtr___9__41_0;

			// Token: 0x04000DAA RID: 3498
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000DAB RID: 3499
			private static readonly IntPtr NativeMethodInfoPtr__ToString_b__7_0_Internal_String_Command_0;

			// Token: 0x04000DAC RID: 3500
			private static readonly IntPtr NativeMethodInfoPtr__AddAfterAll_b__33_0_Internal_IEnumerator_Command_0;

			// Token: 0x04000DAD RID: 3501
			private static readonly IntPtr NativeMethodInfoPtr__AddAfterFirst_b__37_0_Internal_IEnumerator_Command_0;

			// Token: 0x04000DAE RID: 3502
			private static readonly IntPtr NativeMethodInfoPtr__AddBeforeAll_b__41_0_Internal_IEnumerator_Command_0;
		}

		// Token: 0x020001D8 RID: 472
		[ObfuscatedName("zen.src.match.sequences.zenCommands.SequenceBuilder+<>c__27`1")]
		[Serializable]
		public sealed class __c__27<T> : global::Il2CppSystem.Object
		{
			// Token: 0x06001689 RID: 5769 RVA: 0x00056A54 File Offset: 0x00054C54
			// Note: this type is marked as 'beforefieldinit'.
			static __c__27()
			{
				Il2CppClassPointerStore<SequenceBuilder.__c__27<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, "<>c__27`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceBuilder.__c__27<T>>.NativeClassPtr);
				SequenceBuilder.__c__27<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__27<T>>.NativeClassPtr, "<>9");
				SequenceBuilder.__c__27<T>.NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__27<T>>.NativeClassPtr, "<>9__27_0");
				SequenceBuilder.__c__27<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__27<T>>.NativeClassPtr, 100664119);
				SequenceBuilder.__c__27<T>.NativeMethodInfoPtr__BookendAll_b__27_0_Internal_Boolean_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__27<T>>.NativeClassPtr, 100664120);
			}

			// Token: 0x0600168A RID: 5770 RVA: 0x00056B0C File Offset: 0x00054D0C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__27()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceBuilder.__c__27<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__27<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600168B RID: 5771 RVA: 0x00056B48 File Offset: 0x00054D48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BookendAll_b__27_0(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__27<T>.NativeMethodInfoPtr__BookendAll_b__27_0_Internal_Boolean_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600168C RID: 5772 RVA: 0x0000C896 File Offset: 0x0000AA96
			public __c__27(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000680 RID: 1664
			// (get) Token: 0x0600168D RID: 5773 RVA: 0x00056B98 File Offset: 0x00054D98
			// (set) Token: 0x0600168E RID: 5774 RVA: 0x0000C89F File Offset: 0x0000AA9F
			public unsafe static SequenceBuilder.__c__27<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequenceBuilder.__c__27<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceBuilder.__c__27<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequenceBuilder.__c__27<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000681 RID: 1665
			// (get) Token: 0x0600168F RID: 5775 RVA: 0x00056BC0 File Offset: 0x00054DC0
			// (set) Token: 0x06001690 RID: 5776 RVA: 0x0000C8B1 File Offset: 0x0000AAB1
			public unsafe static Func<Command, bool> __9__27_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequenceBuilder.__c__27<T>.NativeFieldInfoPtr___9__27_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Command, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequenceBuilder.__c__27<T>.NativeFieldInfoPtr___9__27_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DAF RID: 3503
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000DB0 RID: 3504
			private static readonly IntPtr NativeFieldInfoPtr___9__27_0;

			// Token: 0x04000DB1 RID: 3505
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000DB2 RID: 3506
			private static readonly IntPtr NativeMethodInfoPtr__BookendAll_b__27_0_Internal_Boolean_Command_0;
		}

		// Token: 0x020001D9 RID: 473
		[ObfuscatedName("zen.src.match.sequences.zenCommands.SequenceBuilder+<>c__28`1")]
		[Serializable]
		public sealed class __c__28<T> : global::Il2CppSystem.Object
		{
			// Token: 0x06001691 RID: 5777 RVA: 0x00056BE8 File Offset: 0x00054DE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__28()
			{
				Il2CppClassPointerStore<SequenceBuilder.__c__28<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, "<>c__28`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceBuilder.__c__28<T>>.NativeClassPtr);
				SequenceBuilder.__c__28<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__28<T>>.NativeClassPtr, "<>9");
				SequenceBuilder.__c__28<T>.NativeFieldInfoPtr___9__28_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__28<T>>.NativeClassPtr, "<>9__28_1");
				SequenceBuilder.__c__28<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__28<T>>.NativeClassPtr, 100664122);
				SequenceBuilder.__c__28<T>.NativeMethodInfoPtr__BookendAll_b__28_1_Internal_Boolean_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__28<T>>.NativeClassPtr, 100664123);
			}

			// Token: 0x06001692 RID: 5778 RVA: 0x00056CA0 File Offset: 0x00054EA0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__28()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceBuilder.__c__28<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__28<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001693 RID: 5779 RVA: 0x00056CDC File Offset: 0x00054EDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BookendAll_b__28_1(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__28<T>.NativeMethodInfoPtr__BookendAll_b__28_1_Internal_Boolean_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001694 RID: 5780 RVA: 0x0000C8C3 File Offset: 0x0000AAC3
			public __c__28(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000682 RID: 1666
			// (get) Token: 0x06001695 RID: 5781 RVA: 0x00056D2C File Offset: 0x00054F2C
			// (set) Token: 0x06001696 RID: 5782 RVA: 0x0000C8CC File Offset: 0x0000AACC
			public unsafe static SequenceBuilder.__c__28<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequenceBuilder.__c__28<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceBuilder.__c__28<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequenceBuilder.__c__28<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000683 RID: 1667
			// (get) Token: 0x06001697 RID: 5783 RVA: 0x00056D54 File Offset: 0x00054F54
			// (set) Token: 0x06001698 RID: 5784 RVA: 0x0000C8DE File Offset: 0x0000AADE
			public unsafe static Func<Command, bool> __9__28_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequenceBuilder.__c__28<T>.NativeFieldInfoPtr___9__28_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Command, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequenceBuilder.__c__28<T>.NativeFieldInfoPtr___9__28_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DB3 RID: 3507
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000DB4 RID: 3508
			private static readonly IntPtr NativeFieldInfoPtr___9__28_1;

			// Token: 0x04000DB5 RID: 3509
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000DB6 RID: 3510
			private static readonly IntPtr NativeMethodInfoPtr__BookendAll_b__28_1_Internal_Boolean_Command_0;
		}

		// Token: 0x020001DA RID: 474
		[ObfuscatedName("zen.src.match.sequences.zenCommands.SequenceBuilder+<>c__31`1")]
		[Serializable]
		public sealed class __c__31<T> : global::Il2CppSystem.Object where T : Command
		{
			// Token: 0x06001699 RID: 5785 RVA: 0x00056D7C File Offset: 0x00054F7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__31()
			{
				Il2CppClassPointerStore<SequenceBuilder.__c__31<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, "<>c__31`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceBuilder.__c__31<T>>.NativeClassPtr);
				SequenceBuilder.__c__31<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__31<T>>.NativeClassPtr, "<>9");
				SequenceBuilder.__c__31<T>.NativeFieldInfoPtr___9__31_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__31<T>>.NativeClassPtr, "<>9__31_1");
				SequenceBuilder.__c__31<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__31<T>>.NativeClassPtr, 100664125);
				SequenceBuilder.__c__31<T>.NativeMethodInfoPtr__BookendFirst_b__31_1_Internal_Boolean_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__31<T>>.NativeClassPtr, 100664126);
			}

			// Token: 0x0600169A RID: 5786 RVA: 0x00056E34 File Offset: 0x00055034
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__31()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceBuilder.__c__31<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__31<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600169B RID: 5787 RVA: 0x00056E70 File Offset: 0x00055070
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BookendFirst_b__31_1(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__31<T>.NativeMethodInfoPtr__BookendFirst_b__31_1_Internal_Boolean_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600169C RID: 5788 RVA: 0x0000C8F0 File Offset: 0x0000AAF0
			public __c__31(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000684 RID: 1668
			// (get) Token: 0x0600169D RID: 5789 RVA: 0x00056EC0 File Offset: 0x000550C0
			// (set) Token: 0x0600169E RID: 5790 RVA: 0x0000C8F9 File Offset: 0x0000AAF9
			public unsafe static SequenceBuilder.__c__31<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequenceBuilder.__c__31<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceBuilder.__c__31<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequenceBuilder.__c__31<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000685 RID: 1669
			// (get) Token: 0x0600169F RID: 5791 RVA: 0x00056EE8 File Offset: 0x000550E8
			// (set) Token: 0x060016A0 RID: 5792 RVA: 0x0000C90B File Offset: 0x0000AB0B
			public unsafe static Func<Command, bool> __9__31_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequenceBuilder.__c__31<T>.NativeFieldInfoPtr___9__31_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Command, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequenceBuilder.__c__31<T>.NativeFieldInfoPtr___9__31_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DB7 RID: 3511
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000DB8 RID: 3512
			private static readonly IntPtr NativeFieldInfoPtr___9__31_1;

			// Token: 0x04000DB9 RID: 3513
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000DBA RID: 3514
			private static readonly IntPtr NativeMethodInfoPtr__BookendFirst_b__31_1_Internal_Boolean_Command_0;
		}

		// Token: 0x020001DB RID: 475
		[ObfuscatedName("zen.src.match.sequences.zenCommands.SequenceBuilder+<>c__32`1")]
		[Serializable]
		public sealed class __c__32<T> : global::Il2CppSystem.Object
		{
			// Token: 0x060016A1 RID: 5793 RVA: 0x00056F10 File Offset: 0x00055110
			// Note: this type is marked as 'beforefieldinit'.
			static __c__32()
			{
				Il2CppClassPointerStore<SequenceBuilder.__c__32<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, "<>c__32`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceBuilder.__c__32<T>>.NativeClassPtr);
				SequenceBuilder.__c__32<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__32<T>>.NativeClassPtr, "<>9");
				SequenceBuilder.__c__32<T>.NativeFieldInfoPtr___9__32_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__32<T>>.NativeClassPtr, "<>9__32_1");
				SequenceBuilder.__c__32<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__32<T>>.NativeClassPtr, 100664128);
				SequenceBuilder.__c__32<T>.NativeMethodInfoPtr__BookendFirst_b__32_1_Internal_Boolean_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__32<T>>.NativeClassPtr, 100664129);
			}

			// Token: 0x060016A2 RID: 5794 RVA: 0x00056FC8 File Offset: 0x000551C8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__32()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceBuilder.__c__32<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__32<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016A3 RID: 5795 RVA: 0x00057004 File Offset: 0x00055204
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BookendFirst_b__32_1(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__32<T>.NativeMethodInfoPtr__BookendFirst_b__32_1_Internal_Boolean_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060016A4 RID: 5796 RVA: 0x0000C91D File Offset: 0x0000AB1D
			public __c__32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000686 RID: 1670
			// (get) Token: 0x060016A5 RID: 5797 RVA: 0x00057054 File Offset: 0x00055254
			// (set) Token: 0x060016A6 RID: 5798 RVA: 0x0000C926 File Offset: 0x0000AB26
			public unsafe static SequenceBuilder.__c__32<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequenceBuilder.__c__32<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceBuilder.__c__32<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequenceBuilder.__c__32<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000687 RID: 1671
			// (get) Token: 0x060016A7 RID: 5799 RVA: 0x0005707C File Offset: 0x0005527C
			// (set) Token: 0x060016A8 RID: 5800 RVA: 0x0000C938 File Offset: 0x0000AB38
			public unsafe static Func<Command, bool> __9__32_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequenceBuilder.__c__32<T>.NativeFieldInfoPtr___9__32_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Command, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequenceBuilder.__c__32<T>.NativeFieldInfoPtr___9__32_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DBB RID: 3515
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000DBC RID: 3516
			private static readonly IntPtr NativeFieldInfoPtr___9__32_1;

			// Token: 0x04000DBD RID: 3517
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000DBE RID: 3518
			private static readonly IntPtr NativeMethodInfoPtr__BookendFirst_b__32_1_Internal_Boolean_Command_0;
		}

		// Token: 0x020001DC RID: 476
		[ObfuscatedName("zen.src.match.sequences.zenCommands.SequenceBuilder+<>c__35`1")]
		[Serializable]
		public sealed class __c__35<T> : global::Il2CppSystem.Object where T : Command
		{
			// Token: 0x060016A9 RID: 5801 RVA: 0x000570A4 File Offset: 0x000552A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__35()
			{
				Il2CppClassPointerStore<SequenceBuilder.__c__35<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, "<>c__35`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceBuilder.__c__35<T>>.NativeClassPtr);
				SequenceBuilder.__c__35<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__35<T>>.NativeClassPtr, "<>9");
				SequenceBuilder.__c__35<T>.NativeFieldInfoPtr___9__35_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__35<T>>.NativeClassPtr, "<>9__35_0");
				SequenceBuilder.__c__35<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__35<T>>.NativeClassPtr, 100664131);
				SequenceBuilder.__c__35<T>.NativeMethodInfoPtr__AddAfterAll_b__35_0_Internal_Boolean_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__35<T>>.NativeClassPtr, 100664132);
			}

			// Token: 0x060016AA RID: 5802 RVA: 0x0005715C File Offset: 0x0005535C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__35()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceBuilder.__c__35<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__35<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016AB RID: 5803 RVA: 0x00057198 File Offset: 0x00055398
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddAfterAll_b__35_0(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__35<T>.NativeMethodInfoPtr__AddAfterAll_b__35_0_Internal_Boolean_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060016AC RID: 5804 RVA: 0x0000C94A File Offset: 0x0000AB4A
			public __c__35(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000688 RID: 1672
			// (get) Token: 0x060016AD RID: 5805 RVA: 0x000571E8 File Offset: 0x000553E8
			// (set) Token: 0x060016AE RID: 5806 RVA: 0x0000C953 File Offset: 0x0000AB53
			public unsafe static SequenceBuilder.__c__35<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequenceBuilder.__c__35<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceBuilder.__c__35<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequenceBuilder.__c__35<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000689 RID: 1673
			// (get) Token: 0x060016AF RID: 5807 RVA: 0x00057210 File Offset: 0x00055410
			// (set) Token: 0x060016B0 RID: 5808 RVA: 0x0000C965 File Offset: 0x0000AB65
			public unsafe static Func<Command, bool> __9__35_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequenceBuilder.__c__35<T>.NativeFieldInfoPtr___9__35_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Command, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequenceBuilder.__c__35<T>.NativeFieldInfoPtr___9__35_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DBF RID: 3519
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000DC0 RID: 3520
			private static readonly IntPtr NativeFieldInfoPtr___9__35_0;

			// Token: 0x04000DC1 RID: 3521
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000DC2 RID: 3522
			private static readonly IntPtr NativeMethodInfoPtr__AddAfterAll_b__35_0_Internal_Boolean_Command_0;
		}

		// Token: 0x020001DD RID: 477
		[ObfuscatedName("zen.src.match.sequences.zenCommands.SequenceBuilder+<>c__36`1")]
		[Serializable]
		public sealed class __c__36<T> : global::Il2CppSystem.Object
		{
			// Token: 0x060016B1 RID: 5809 RVA: 0x00057238 File Offset: 0x00055438
			// Note: this type is marked as 'beforefieldinit'.
			static __c__36()
			{
				Il2CppClassPointerStore<SequenceBuilder.__c__36<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, "<>c__36`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceBuilder.__c__36<T>>.NativeClassPtr);
				SequenceBuilder.__c__36<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__36<T>>.NativeClassPtr, "<>9");
				SequenceBuilder.__c__36<T>.NativeFieldInfoPtr___9__36_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__36<T>>.NativeClassPtr, "<>9__36_0");
				SequenceBuilder.__c__36<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__36<T>>.NativeClassPtr, 100664134);
				SequenceBuilder.__c__36<T>.NativeMethodInfoPtr__AddAfterAll_b__36_0_Internal_Boolean_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__36<T>>.NativeClassPtr, 100664135);
			}

			// Token: 0x060016B2 RID: 5810 RVA: 0x000572F0 File Offset: 0x000554F0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__36()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceBuilder.__c__36<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__36<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016B3 RID: 5811 RVA: 0x0005732C File Offset: 0x0005552C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddAfterAll_b__36_0(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__36<T>.NativeMethodInfoPtr__AddAfterAll_b__36_0_Internal_Boolean_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060016B4 RID: 5812 RVA: 0x0000C977 File Offset: 0x0000AB77
			public __c__36(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700068A RID: 1674
			// (get) Token: 0x060016B5 RID: 5813 RVA: 0x0005737C File Offset: 0x0005557C
			// (set) Token: 0x060016B6 RID: 5814 RVA: 0x0000C980 File Offset: 0x0000AB80
			public unsafe static SequenceBuilder.__c__36<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequenceBuilder.__c__36<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceBuilder.__c__36<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequenceBuilder.__c__36<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700068B RID: 1675
			// (get) Token: 0x060016B7 RID: 5815 RVA: 0x000573A4 File Offset: 0x000555A4
			// (set) Token: 0x060016B8 RID: 5816 RVA: 0x0000C992 File Offset: 0x0000AB92
			public unsafe static Func<Command, bool> __9__36_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequenceBuilder.__c__36<T>.NativeFieldInfoPtr___9__36_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Command, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequenceBuilder.__c__36<T>.NativeFieldInfoPtr___9__36_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DC3 RID: 3523
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000DC4 RID: 3524
			private static readonly IntPtr NativeFieldInfoPtr___9__36_0;

			// Token: 0x04000DC5 RID: 3525
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000DC6 RID: 3526
			private static readonly IntPtr NativeMethodInfoPtr__AddAfterAll_b__36_0_Internal_Boolean_Command_0;
		}

		// Token: 0x020001DE RID: 478
		[ObfuscatedName("zen.src.match.sequences.zenCommands.SequenceBuilder+<>c__39`1")]
		[Serializable]
		public sealed class __c__39<T> : global::Il2CppSystem.Object where T : Command
		{
			// Token: 0x060016B9 RID: 5817 RVA: 0x000573CC File Offset: 0x000555CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__39()
			{
				Il2CppClassPointerStore<SequenceBuilder.__c__39<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, "<>c__39`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceBuilder.__c__39<T>>.NativeClassPtr);
				SequenceBuilder.__c__39<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__39<T>>.NativeClassPtr, "<>9");
				SequenceBuilder.__c__39<T>.NativeFieldInfoPtr___9__39_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__39<T>>.NativeClassPtr, "<>9__39_0");
				SequenceBuilder.__c__39<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__39<T>>.NativeClassPtr, 100664137);
				SequenceBuilder.__c__39<T>.NativeMethodInfoPtr__AddAfterFirst_b__39_0_Internal_IEnumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__39<T>>.NativeClassPtr, 100664138);
			}

			// Token: 0x060016BA RID: 5818 RVA: 0x00057484 File Offset: 0x00055684
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__39()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceBuilder.__c__39<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__39<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016BB RID: 5819 RVA: 0x000574C0 File Offset: 0x000556C0
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _AddAfterFirst_b__39_0(T _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = _;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref _;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__39<T>.NativeMethodInfoPtr__AddAfterFirst_b__39_0_Internal_IEnumerator_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr2;
					return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr4) : null;
				}
			}

			// Token: 0x060016BC RID: 5820 RVA: 0x0000C9A4 File Offset: 0x0000ABA4
			public __c__39(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700068C RID: 1676
			// (get) Token: 0x060016BD RID: 5821 RVA: 0x00057548 File Offset: 0x00055748
			// (set) Token: 0x060016BE RID: 5822 RVA: 0x0000C9AD File Offset: 0x0000ABAD
			public unsafe static SequenceBuilder.__c__39<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequenceBuilder.__c__39<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceBuilder.__c__39<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequenceBuilder.__c__39<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700068D RID: 1677
			// (get) Token: 0x060016BF RID: 5823 RVA: 0x00057570 File Offset: 0x00055770
			// (set) Token: 0x060016C0 RID: 5824 RVA: 0x0000C9BF File Offset: 0x0000ABBF
			public unsafe static Func<T, IEnumerator> __9__39_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequenceBuilder.__c__39<T>.NativeFieldInfoPtr___9__39_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequenceBuilder.__c__39<T>.NativeFieldInfoPtr___9__39_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DC7 RID: 3527
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000DC8 RID: 3528
			private static readonly IntPtr NativeFieldInfoPtr___9__39_0;

			// Token: 0x04000DC9 RID: 3529
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000DCA RID: 3530
			private static readonly IntPtr NativeMethodInfoPtr__AddAfterFirst_b__39_0_Internal_IEnumerator_T_0;
		}

		// Token: 0x020001DF RID: 479
		[ObfuscatedName("zen.src.match.sequences.zenCommands.SequenceBuilder+<>c__40`1")]
		[Serializable]
		public sealed class __c__40<T> : global::Il2CppSystem.Object
		{
			// Token: 0x060016C1 RID: 5825 RVA: 0x00057598 File Offset: 0x00055798
			// Note: this type is marked as 'beforefieldinit'.
			static __c__40()
			{
				Il2CppClassPointerStore<SequenceBuilder.__c__40<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, "<>c__40`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceBuilder.__c__40<T>>.NativeClassPtr);
				SequenceBuilder.__c__40<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__40<T>>.NativeClassPtr, "<>9");
				SequenceBuilder.__c__40<T>.NativeFieldInfoPtr___9__40_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__40<T>>.NativeClassPtr, "<>9__40_0");
				SequenceBuilder.__c__40<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__40<T>>.NativeClassPtr, 100664140);
				SequenceBuilder.__c__40<T>.NativeMethodInfoPtr__AddAfterFirst_b__40_0_Internal_Boolean_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__40<T>>.NativeClassPtr, 100664141);
			}

			// Token: 0x060016C2 RID: 5826 RVA: 0x00057650 File Offset: 0x00055850
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__40()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceBuilder.__c__40<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__40<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016C3 RID: 5827 RVA: 0x0005768C File Offset: 0x0005588C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddAfterFirst_b__40_0(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__40<T>.NativeMethodInfoPtr__AddAfterFirst_b__40_0_Internal_Boolean_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060016C4 RID: 5828 RVA: 0x0000C9D1 File Offset: 0x0000ABD1
			public __c__40(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700068E RID: 1678
			// (get) Token: 0x060016C5 RID: 5829 RVA: 0x000576DC File Offset: 0x000558DC
			// (set) Token: 0x060016C6 RID: 5830 RVA: 0x0000C9DA File Offset: 0x0000ABDA
			public unsafe static SequenceBuilder.__c__40<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequenceBuilder.__c__40<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceBuilder.__c__40<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequenceBuilder.__c__40<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700068F RID: 1679
			// (get) Token: 0x060016C7 RID: 5831 RVA: 0x00057704 File Offset: 0x00055904
			// (set) Token: 0x060016C8 RID: 5832 RVA: 0x0000C9EC File Offset: 0x0000ABEC
			public unsafe static Func<Command, bool> __9__40_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequenceBuilder.__c__40<T>.NativeFieldInfoPtr___9__40_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Command, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequenceBuilder.__c__40<T>.NativeFieldInfoPtr___9__40_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DCB RID: 3531
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000DCC RID: 3532
			private static readonly IntPtr NativeFieldInfoPtr___9__40_0;

			// Token: 0x04000DCD RID: 3533
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000DCE RID: 3534
			private static readonly IntPtr NativeMethodInfoPtr__AddAfterFirst_b__40_0_Internal_Boolean_Command_0;
		}

		// Token: 0x020001E0 RID: 480
		[ObfuscatedName("zen.src.match.sequences.zenCommands.SequenceBuilder+<>c__43`1")]
		[Serializable]
		public sealed class __c__43<T> : global::Il2CppSystem.Object where T : Command
		{
			// Token: 0x060016C9 RID: 5833 RVA: 0x0005772C File Offset: 0x0005592C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__43()
			{
				Il2CppClassPointerStore<SequenceBuilder.__c__43<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, "<>c__43`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceBuilder.__c__43<T>>.NativeClassPtr);
				SequenceBuilder.__c__43<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__43<T>>.NativeClassPtr, "<>9");
				SequenceBuilder.__c__43<T>.NativeFieldInfoPtr___9__43_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__43<T>>.NativeClassPtr, "<>9__43_1");
				SequenceBuilder.__c__43<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__43<T>>.NativeClassPtr, 100664143);
				SequenceBuilder.__c__43<T>.NativeMethodInfoPtr__AddBeforeAll_b__43_1_Internal_Boolean_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__43<T>>.NativeClassPtr, 100664144);
			}

			// Token: 0x060016CA RID: 5834 RVA: 0x000577E4 File Offset: 0x000559E4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__43()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceBuilder.__c__43<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__43<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016CB RID: 5835 RVA: 0x00057820 File Offset: 0x00055A20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddBeforeAll_b__43_1(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__43<T>.NativeMethodInfoPtr__AddBeforeAll_b__43_1_Internal_Boolean_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060016CC RID: 5836 RVA: 0x0000C9FE File Offset: 0x0000ABFE
			public __c__43(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000690 RID: 1680
			// (get) Token: 0x060016CD RID: 5837 RVA: 0x00057870 File Offset: 0x00055A70
			// (set) Token: 0x060016CE RID: 5838 RVA: 0x0000CA07 File Offset: 0x0000AC07
			public unsafe static SequenceBuilder.__c__43<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequenceBuilder.__c__43<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceBuilder.__c__43<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequenceBuilder.__c__43<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000691 RID: 1681
			// (get) Token: 0x060016CF RID: 5839 RVA: 0x00057898 File Offset: 0x00055A98
			// (set) Token: 0x060016D0 RID: 5840 RVA: 0x0000CA19 File Offset: 0x0000AC19
			public unsafe static Func<Command, bool> __9__43_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequenceBuilder.__c__43<T>.NativeFieldInfoPtr___9__43_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Command, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequenceBuilder.__c__43<T>.NativeFieldInfoPtr___9__43_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DCF RID: 3535
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000DD0 RID: 3536
			private static readonly IntPtr NativeFieldInfoPtr___9__43_1;

			// Token: 0x04000DD1 RID: 3537
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000DD2 RID: 3538
			private static readonly IntPtr NativeMethodInfoPtr__AddBeforeAll_b__43_1_Internal_Boolean_Command_0;
		}

		// Token: 0x020001E1 RID: 481
		[ObfuscatedName("zen.src.match.sequences.zenCommands.SequenceBuilder+<>c__44`1")]
		[Serializable]
		public sealed class __c__44<T> : global::Il2CppSystem.Object
		{
			// Token: 0x060016D1 RID: 5841 RVA: 0x000578C0 File Offset: 0x00055AC0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__44()
			{
				Il2CppClassPointerStore<SequenceBuilder.__c__44<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, "<>c__44`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceBuilder.__c__44<T>>.NativeClassPtr);
				SequenceBuilder.__c__44<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__44<T>>.NativeClassPtr, "<>9");
				SequenceBuilder.__c__44<T>.NativeFieldInfoPtr___9__44_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__44<T>>.NativeClassPtr, "<>9__44_1");
				SequenceBuilder.__c__44<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__44<T>>.NativeClassPtr, 100664146);
				SequenceBuilder.__c__44<T>.NativeMethodInfoPtr__AddBeforeAll_b__44_1_Internal_Boolean_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__44<T>>.NativeClassPtr, 100664147);
			}

			// Token: 0x060016D2 RID: 5842 RVA: 0x00057978 File Offset: 0x00055B78
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__44()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceBuilder.__c__44<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__44<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016D3 RID: 5843 RVA: 0x000579B4 File Offset: 0x00055BB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddBeforeAll_b__44_1(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__44<T>.NativeMethodInfoPtr__AddBeforeAll_b__44_1_Internal_Boolean_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060016D4 RID: 5844 RVA: 0x0000CA2B File Offset: 0x0000AC2B
			public __c__44(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000692 RID: 1682
			// (get) Token: 0x060016D5 RID: 5845 RVA: 0x00057A04 File Offset: 0x00055C04
			// (set) Token: 0x060016D6 RID: 5846 RVA: 0x0000CA34 File Offset: 0x0000AC34
			public unsafe static SequenceBuilder.__c__44<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequenceBuilder.__c__44<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceBuilder.__c__44<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequenceBuilder.__c__44<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000693 RID: 1683
			// (get) Token: 0x060016D7 RID: 5847 RVA: 0x00057A2C File Offset: 0x00055C2C
			// (set) Token: 0x060016D8 RID: 5848 RVA: 0x0000CA46 File Offset: 0x0000AC46
			public unsafe static Func<Command, bool> __9__44_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SequenceBuilder.__c__44<T>.NativeFieldInfoPtr___9__44_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Command, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SequenceBuilder.__c__44<T>.NativeFieldInfoPtr___9__44_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DD3 RID: 3539
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000DD4 RID: 3540
			private static readonly IntPtr NativeFieldInfoPtr___9__44_1;

			// Token: 0x04000DD5 RID: 3541
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000DD6 RID: 3542
			private static readonly IntPtr NativeMethodInfoPtr__AddBeforeAll_b__44_1_Internal_Boolean_Command_0;
		}

		// Token: 0x020001E2 RID: 482
		[ObfuscatedName("zen.src.match.sequences.zenCommands.SequenceBuilder+<>c__DisplayClass17_0`1")]
		public sealed class __c__DisplayClass17_0<T> : global::Il2CppSystem.Object where T : Command
		{
			// Token: 0x060016D9 RID: 5849 RVA: 0x00057A54 File Offset: 0x00055C54
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass17_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, "<>c__DisplayClass17_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass17_0<T>>.NativeClassPtr);
				SequenceBuilder.__c__DisplayClass17_0<T>.NativeFieldInfoPtr_replaceWith = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass17_0<T>>.NativeClassPtr, "replaceWith");
				SequenceBuilder.__c__DisplayClass17_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass17_0<T>>.NativeClassPtr, 100664148);
				SequenceBuilder.__c__DisplayClass17_0<T>.NativeMethodInfoPtr__WrapAll_b__0_Internal_IEnumerator_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass17_0<T>>.NativeClassPtr, 100664149);
			}

			// Token: 0x060016DA RID: 5850 RVA: 0x00057AF8 File Offset: 0x00055CF8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass17_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass17_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016DB RID: 5851 RVA: 0x00057B34 File Offset: 0x00055D34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987204, XrefRangeEnd = 987208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _WrapAll_b__0(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass17_0<T>.NativeMethodInfoPtr__WrapAll_b__0_Internal_IEnumerator_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x060016DC RID: 5852 RVA: 0x0000CA58 File Offset: 0x0000AC58
			public __c__DisplayClass17_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000694 RID: 1684
			// (get) Token: 0x060016DD RID: 5853 RVA: 0x00057B84 File Offset: 0x00055D84
			// (set) Token: 0x060016DE RID: 5854 RVA: 0x0000CA61 File Offset: 0x0000AC61
			public unsafe Func<T, Command> replaceWith
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass17_0<T>.NativeFieldInfoPtr_replaceWith);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, Command>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass17_0<T>.NativeFieldInfoPtr_replaceWith), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DD7 RID: 3543
			private static readonly IntPtr NativeFieldInfoPtr_replaceWith;

			// Token: 0x04000DD8 RID: 3544
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000DD9 RID: 3545
			private static readonly IntPtr NativeMethodInfoPtr__WrapAll_b__0_Internal_IEnumerator_Command_0;
		}

		// Token: 0x020001E3 RID: 483
		[ObfuscatedName("zen.src.match.sequences.zenCommands.SequenceBuilder+<>c__DisplayClass19_0`1")]
		public sealed class __c__DisplayClass19_0<T> : global::Il2CppSystem.Object where T : Command
		{
			// Token: 0x060016DF RID: 5855 RVA: 0x00057BB4 File Offset: 0x00055DB4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass19_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, "<>c__DisplayClass19_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass19_0<T>>.NativeClassPtr);
				SequenceBuilder.__c__DisplayClass19_0<T>.NativeFieldInfoPtr_replaceWith = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass19_0<T>>.NativeClassPtr, "replaceWith");
				SequenceBuilder.__c__DisplayClass19_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass19_0<T>>.NativeClassPtr, 100664150);
				SequenceBuilder.__c__DisplayClass19_0<T>.NativeMethodInfoPtr__WrapFirst_b__0_Internal_IEnumerator_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass19_0<T>>.NativeClassPtr, 100664151);
			}

			// Token: 0x060016E0 RID: 5856 RVA: 0x00057C58 File Offset: 0x00055E58
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass19_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass19_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016E1 RID: 5857 RVA: 0x00057C94 File Offset: 0x00055E94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _WrapFirst_b__0(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass19_0<T>.NativeMethodInfoPtr__WrapFirst_b__0_Internal_IEnumerator_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x060016E2 RID: 5858 RVA: 0x0000CA80 File Offset: 0x0000AC80
			public __c__DisplayClass19_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000695 RID: 1685
			// (get) Token: 0x060016E3 RID: 5859 RVA: 0x00057CE4 File Offset: 0x00055EE4
			// (set) Token: 0x060016E4 RID: 5860 RVA: 0x0000CA89 File Offset: 0x0000AC89
			public unsafe Func<T, Command> replaceWith
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass19_0<T>.NativeFieldInfoPtr_replaceWith);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, Command>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass19_0<T>.NativeFieldInfoPtr_replaceWith), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DDA RID: 3546
			private static readonly IntPtr NativeFieldInfoPtr_replaceWith;

			// Token: 0x04000DDB RID: 3547
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000DDC RID: 3548
			private static readonly IntPtr NativeMethodInfoPtr__WrapFirst_b__0_Internal_IEnumerator_Command_0;
		}

		// Token: 0x020001E4 RID: 484
		[ObfuscatedName("zen.src.match.sequences.zenCommands.SequenceBuilder+<>c__DisplayClass21_0`1")]
		public sealed class __c__DisplayClass21_0<T> : global::Il2CppSystem.Object where T : Command
		{
			// Token: 0x060016E5 RID: 5861 RVA: 0x00057D14 File Offset: 0x00055F14
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass21_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, "<>c__DisplayClass21_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass21_0<T>>.NativeClassPtr);
				SequenceBuilder.__c__DisplayClass21_0<T>.NativeFieldInfoPtr_replaceWith = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass21_0<T>>.NativeClassPtr, "replaceWith");
				SequenceBuilder.__c__DisplayClass21_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass21_0<T>>.NativeClassPtr, 100664152);
				SequenceBuilder.__c__DisplayClass21_0<T>.NativeMethodInfoPtr__WrapLast_b__0_Internal_IEnumerator_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass21_0<T>>.NativeClassPtr, 100664153);
			}

			// Token: 0x060016E6 RID: 5862 RVA: 0x00057DB8 File Offset: 0x00055FB8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass21_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass21_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016E7 RID: 5863 RVA: 0x00057DF4 File Offset: 0x00055FF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _WrapLast_b__0(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass21_0<T>.NativeMethodInfoPtr__WrapLast_b__0_Internal_IEnumerator_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x060016E8 RID: 5864 RVA: 0x0000CAA8 File Offset: 0x0000ACA8
			public __c__DisplayClass21_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000696 RID: 1686
			// (get) Token: 0x060016E9 RID: 5865 RVA: 0x00057E44 File Offset: 0x00056044
			// (set) Token: 0x060016EA RID: 5866 RVA: 0x0000CAB1 File Offset: 0x0000ACB1
			public unsafe Func<T, Command> replaceWith
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass21_0<T>.NativeFieldInfoPtr_replaceWith);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, Command>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass21_0<T>.NativeFieldInfoPtr_replaceWith), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DDD RID: 3549
			private static readonly IntPtr NativeFieldInfoPtr_replaceWith;

			// Token: 0x04000DDE RID: 3550
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000DDF RID: 3551
			private static readonly IntPtr NativeMethodInfoPtr__WrapLast_b__0_Internal_IEnumerator_Command_0;
		}

		// Token: 0x020001E5 RID: 485
		[ObfuscatedName("zen.src.match.sequences.zenCommands.SequenceBuilder+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060016EB RID: 5867 RVA: 0x00057E74 File Offset: 0x00056074
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass26_0>.NativeClassPtr);
				SequenceBuilder.__c__DisplayClass26_0.NativeFieldInfoPtr_beforeCommandBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass26_0>.NativeClassPtr, "beforeCommandBuilder");
				SequenceBuilder.__c__DisplayClass26_0.NativeFieldInfoPtr_afterCommandBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass26_0>.NativeClassPtr, "afterCommandBuilder");
				SequenceBuilder.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass26_0>.NativeClassPtr, 100664154);
				SequenceBuilder.__c__DisplayClass26_0.NativeMethodInfoPtr__BookendAll_b__0_Internal_IEnumerator_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass26_0>.NativeClassPtr, 100664155);
				SequenceBuilder.__c__DisplayClass26_0.NativeMethodInfoPtr__BookendAll_b__1_Internal_IEnumerator_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass26_0>.NativeClassPtr, 100664156);
			}

			// Token: 0x060016EC RID: 5868 RVA: 0x00057F04 File Offset: 0x00056104
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016ED RID: 5869 RVA: 0x00057F40 File Offset: 0x00056140
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _BookendAll_b__0(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass26_0.NativeMethodInfoPtr__BookendAll_b__0_Internal_IEnumerator_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x060016EE RID: 5870 RVA: 0x00057F90 File Offset: 0x00056190
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _BookendAll_b__1(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass26_0.NativeMethodInfoPtr__BookendAll_b__1_Internal_IEnumerator_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x060016EF RID: 5871 RVA: 0x0000CAD0 File Offset: 0x0000ACD0
			public __c__DisplayClass26_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000697 RID: 1687
			// (get) Token: 0x060016F0 RID: 5872 RVA: 0x00057FE0 File Offset: 0x000561E0
			// (set) Token: 0x060016F1 RID: 5873 RVA: 0x0000CAD9 File Offset: 0x0000ACD9
			public unsafe Func<IEnumerator> beforeCommandBuilder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass26_0.NativeFieldInfoPtr_beforeCommandBuilder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass26_0.NativeFieldInfoPtr_beforeCommandBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000698 RID: 1688
			// (get) Token: 0x060016F2 RID: 5874 RVA: 0x00058010 File Offset: 0x00056210
			// (set) Token: 0x060016F3 RID: 5875 RVA: 0x0000CAF8 File Offset: 0x0000ACF8
			public unsafe Func<IEnumerator> afterCommandBuilder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass26_0.NativeFieldInfoPtr_afterCommandBuilder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass26_0.NativeFieldInfoPtr_afterCommandBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DE0 RID: 3552
			private static readonly IntPtr NativeFieldInfoPtr_beforeCommandBuilder;

			// Token: 0x04000DE1 RID: 3553
			private static readonly IntPtr NativeFieldInfoPtr_afterCommandBuilder;

			// Token: 0x04000DE2 RID: 3554
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000DE3 RID: 3555
			private static readonly IntPtr NativeMethodInfoPtr__BookendAll_b__0_Internal_IEnumerator_Command_0;

			// Token: 0x04000DE4 RID: 3556
			private static readonly IntPtr NativeMethodInfoPtr__BookendAll_b__1_Internal_IEnumerator_Command_0;
		}

		// Token: 0x020001E6 RID: 486
		[ObfuscatedName("zen.src.match.sequences.zenCommands.SequenceBuilder+<>c__DisplayClass28_0`1")]
		public sealed class __c__DisplayClass28_0<T> : global::Il2CppSystem.Object
		{
			// Token: 0x060016F4 RID: 5876 RVA: 0x00058040 File Offset: 0x00056240
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass28_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, "<>c__DisplayClass28_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass28_0<T>>.NativeClassPtr);
				SequenceBuilder.__c__DisplayClass28_0<T>.NativeFieldInfoPtr_beforeCommandBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass28_0<T>>.NativeClassPtr, "beforeCommandBuilder");
				SequenceBuilder.__c__DisplayClass28_0<T>.NativeFieldInfoPtr_afterCommandBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass28_0<T>>.NativeClassPtr, "afterCommandBuilder");
				SequenceBuilder.__c__DisplayClass28_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass28_0<T>>.NativeClassPtr, 100664157);
				SequenceBuilder.__c__DisplayClass28_0<T>.NativeMethodInfoPtr__BookendAll_b__0_Internal_IEnumerator_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass28_0<T>>.NativeClassPtr, 100664158);
				SequenceBuilder.__c__DisplayClass28_0<T>.NativeMethodInfoPtr__BookendAll_b__2_Internal_IEnumerator_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass28_0<T>>.NativeClassPtr, 100664159);
			}

			// Token: 0x060016F5 RID: 5877 RVA: 0x0005810C File Offset: 0x0005630C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass28_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass28_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016F6 RID: 5878 RVA: 0x00058148 File Offset: 0x00056348
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _BookendAll_b__0(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass28_0<T>.NativeMethodInfoPtr__BookendAll_b__0_Internal_IEnumerator_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x060016F7 RID: 5879 RVA: 0x00058198 File Offset: 0x00056398
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _BookendAll_b__2(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass28_0<T>.NativeMethodInfoPtr__BookendAll_b__2_Internal_IEnumerator_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x060016F8 RID: 5880 RVA: 0x0000CB17 File Offset: 0x0000AD17
			public __c__DisplayClass28_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000699 RID: 1689
			// (get) Token: 0x060016F9 RID: 5881 RVA: 0x000581E8 File Offset: 0x000563E8
			// (set) Token: 0x060016FA RID: 5882 RVA: 0x0000CB20 File Offset: 0x0000AD20
			public unsafe Func<IEnumerator> beforeCommandBuilder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass28_0<T>.NativeFieldInfoPtr_beforeCommandBuilder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass28_0<T>.NativeFieldInfoPtr_beforeCommandBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700069A RID: 1690
			// (get) Token: 0x060016FB RID: 5883 RVA: 0x00058218 File Offset: 0x00056418
			// (set) Token: 0x060016FC RID: 5884 RVA: 0x0000CB3F File Offset: 0x0000AD3F
			public unsafe Func<IEnumerator> afterCommandBuilder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass28_0<T>.NativeFieldInfoPtr_afterCommandBuilder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass28_0<T>.NativeFieldInfoPtr_afterCommandBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DE5 RID: 3557
			private static readonly IntPtr NativeFieldInfoPtr_beforeCommandBuilder;

			// Token: 0x04000DE6 RID: 3558
			private static readonly IntPtr NativeFieldInfoPtr_afterCommandBuilder;

			// Token: 0x04000DE7 RID: 3559
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000DE8 RID: 3560
			private static readonly IntPtr NativeMethodInfoPtr__BookendAll_b__0_Internal_IEnumerator_Command_0;

			// Token: 0x04000DE9 RID: 3561
			private static readonly IntPtr NativeMethodInfoPtr__BookendAll_b__2_Internal_IEnumerator_Command_0;
		}

		// Token: 0x020001E7 RID: 487
		[ObfuscatedName("zen.src.match.sequences.zenCommands.SequenceBuilder+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060016FD RID: 5885 RVA: 0x00058248 File Offset: 0x00056448
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass30_0>.NativeClassPtr);
				SequenceBuilder.__c__DisplayClass30_0.NativeFieldInfoPtr_beforeCommandBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass30_0>.NativeClassPtr, "beforeCommandBuilder");
				SequenceBuilder.__c__DisplayClass30_0.NativeFieldInfoPtr_afterCommandBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass30_0>.NativeClassPtr, "afterCommandBuilder");
				SequenceBuilder.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass30_0>.NativeClassPtr, 100664160);
				SequenceBuilder.__c__DisplayClass30_0.NativeMethodInfoPtr__BookendFirst_b__0_Internal_IEnumerator_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass30_0>.NativeClassPtr, 100664161);
				SequenceBuilder.__c__DisplayClass30_0.NativeMethodInfoPtr__BookendFirst_b__1_Internal_IEnumerator_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass30_0>.NativeClassPtr, 100664162);
			}

			// Token: 0x060016FE RID: 5886 RVA: 0x000582D8 File Offset: 0x000564D8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016FF RID: 5887 RVA: 0x00058314 File Offset: 0x00056514
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _BookendFirst_b__0(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass30_0.NativeMethodInfoPtr__BookendFirst_b__0_Internal_IEnumerator_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x06001700 RID: 5888 RVA: 0x00058364 File Offset: 0x00056564
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _BookendFirst_b__1(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass30_0.NativeMethodInfoPtr__BookendFirst_b__1_Internal_IEnumerator_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x06001701 RID: 5889 RVA: 0x0000CB5E File Offset: 0x0000AD5E
			public __c__DisplayClass30_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700069B RID: 1691
			// (get) Token: 0x06001702 RID: 5890 RVA: 0x000583B4 File Offset: 0x000565B4
			// (set) Token: 0x06001703 RID: 5891 RVA: 0x0000CB67 File Offset: 0x0000AD67
			public unsafe Func<IEnumerator> beforeCommandBuilder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass30_0.NativeFieldInfoPtr_beforeCommandBuilder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass30_0.NativeFieldInfoPtr_beforeCommandBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700069C RID: 1692
			// (get) Token: 0x06001704 RID: 5892 RVA: 0x000583E4 File Offset: 0x000565E4
			// (set) Token: 0x06001705 RID: 5893 RVA: 0x0000CB86 File Offset: 0x0000AD86
			public unsafe Func<IEnumerator> afterCommandBuilder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass30_0.NativeFieldInfoPtr_afterCommandBuilder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass30_0.NativeFieldInfoPtr_afterCommandBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DEA RID: 3562
			private static readonly IntPtr NativeFieldInfoPtr_beforeCommandBuilder;

			// Token: 0x04000DEB RID: 3563
			private static readonly IntPtr NativeFieldInfoPtr_afterCommandBuilder;

			// Token: 0x04000DEC RID: 3564
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000DED RID: 3565
			private static readonly IntPtr NativeMethodInfoPtr__BookendFirst_b__0_Internal_IEnumerator_Command_0;

			// Token: 0x04000DEE RID: 3566
			private static readonly IntPtr NativeMethodInfoPtr__BookendFirst_b__1_Internal_IEnumerator_Command_0;
		}

		// Token: 0x020001E8 RID: 488
		[ObfuscatedName("zen.src.match.sequences.zenCommands.SequenceBuilder+<>c__DisplayClass31_0`1")]
		public sealed class __c__DisplayClass31_0<T> : global::Il2CppSystem.Object where T : Command
		{
			// Token: 0x06001706 RID: 5894 RVA: 0x00058414 File Offset: 0x00056614
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass31_0()
			{
				Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass31_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, "<>c__DisplayClass31_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass31_0<T>>.NativeClassPtr);
				SequenceBuilder.__c__DisplayClass31_0<T>.NativeFieldInfoPtr_beforeCommandBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass31_0<T>>.NativeClassPtr, "beforeCommandBuilder");
				SequenceBuilder.__c__DisplayClass31_0<T>.NativeFieldInfoPtr_afterCommandBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass31_0<T>>.NativeClassPtr, "afterCommandBuilder");
				SequenceBuilder.__c__DisplayClass31_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass31_0<T>>.NativeClassPtr, 100664163);
				SequenceBuilder.__c__DisplayClass31_0<T>.NativeMethodInfoPtr__BookendFirst_b__0_Internal_IEnumerator_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass31_0<T>>.NativeClassPtr, 100664164);
				SequenceBuilder.__c__DisplayClass31_0<T>.NativeMethodInfoPtr__BookendFirst_b__2_Internal_IEnumerator_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass31_0<T>>.NativeClassPtr, 100664165);
			}

			// Token: 0x06001707 RID: 5895 RVA: 0x000584E0 File Offset: 0x000566E0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass31_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass31_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass31_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001708 RID: 5896 RVA: 0x0005851C File Offset: 0x0005671C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987208, XrefRangeEnd = 987215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _BookendFirst_b__0(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass31_0<T>.NativeMethodInfoPtr__BookendFirst_b__0_Internal_IEnumerator_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x06001709 RID: 5897 RVA: 0x0005856C File Offset: 0x0005676C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987215, XrefRangeEnd = 987235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _BookendFirst_b__2(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass31_0<T>.NativeMethodInfoPtr__BookendFirst_b__2_Internal_IEnumerator_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x0600170A RID: 5898 RVA: 0x0000CBA5 File Offset: 0x0000ADA5
			public __c__DisplayClass31_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700069D RID: 1693
			// (get) Token: 0x0600170B RID: 5899 RVA: 0x000585BC File Offset: 0x000567BC
			// (set) Token: 0x0600170C RID: 5900 RVA: 0x0000CBAE File Offset: 0x0000ADAE
			public unsafe Func<T, IEnumerator> beforeCommandBuilder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass31_0<T>.NativeFieldInfoPtr_beforeCommandBuilder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass31_0<T>.NativeFieldInfoPtr_beforeCommandBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700069E RID: 1694
			// (get) Token: 0x0600170D RID: 5901 RVA: 0x000585EC File Offset: 0x000567EC
			// (set) Token: 0x0600170E RID: 5902 RVA: 0x0000CBCD File Offset: 0x0000ADCD
			public unsafe Func<T, IEnumerator> afterCommandBuilder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass31_0<T>.NativeFieldInfoPtr_afterCommandBuilder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass31_0<T>.NativeFieldInfoPtr_afterCommandBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DEF RID: 3567
			private static readonly IntPtr NativeFieldInfoPtr_beforeCommandBuilder;

			// Token: 0x04000DF0 RID: 3568
			private static readonly IntPtr NativeFieldInfoPtr_afterCommandBuilder;

			// Token: 0x04000DF1 RID: 3569
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000DF2 RID: 3570
			private static readonly IntPtr NativeMethodInfoPtr__BookendFirst_b__0_Internal_IEnumerator_Command_0;

			// Token: 0x04000DF3 RID: 3571
			private static readonly IntPtr NativeMethodInfoPtr__BookendFirst_b__2_Internal_IEnumerator_Command_0;
		}

		// Token: 0x020001E9 RID: 489
		[ObfuscatedName("zen.src.match.sequences.zenCommands.SequenceBuilder+<>c__DisplayClass32_0`1")]
		public sealed class __c__DisplayClass32_0<T> : global::Il2CppSystem.Object
		{
			// Token: 0x0600170F RID: 5903 RVA: 0x0005861C File Offset: 0x0005681C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_0()
			{
				Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass32_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, "<>c__DisplayClass32_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass32_0<T>>.NativeClassPtr);
				SequenceBuilder.__c__DisplayClass32_0<T>.NativeFieldInfoPtr_beforeCommandBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass32_0<T>>.NativeClassPtr, "beforeCommandBuilder");
				SequenceBuilder.__c__DisplayClass32_0<T>.NativeFieldInfoPtr_afterCommandBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass32_0<T>>.NativeClassPtr, "afterCommandBuilder");
				SequenceBuilder.__c__DisplayClass32_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass32_0<T>>.NativeClassPtr, 100664166);
				SequenceBuilder.__c__DisplayClass32_0<T>.NativeMethodInfoPtr__BookendFirst_b__0_Internal_IEnumerator_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass32_0<T>>.NativeClassPtr, 100664167);
				SequenceBuilder.__c__DisplayClass32_0<T>.NativeMethodInfoPtr__BookendFirst_b__2_Internal_IEnumerator_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass32_0<T>>.NativeClassPtr, 100664168);
			}

			// Token: 0x06001710 RID: 5904 RVA: 0x000586E8 File Offset: 0x000568E8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass32_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass32_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001711 RID: 5905 RVA: 0x00058724 File Offset: 0x00056924
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _BookendFirst_b__0(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass32_0<T>.NativeMethodInfoPtr__BookendFirst_b__0_Internal_IEnumerator_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x06001712 RID: 5906 RVA: 0x00058774 File Offset: 0x00056974
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _BookendFirst_b__2(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass32_0<T>.NativeMethodInfoPtr__BookendFirst_b__2_Internal_IEnumerator_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x06001713 RID: 5907 RVA: 0x0000CBEC File Offset: 0x0000ADEC
			public __c__DisplayClass32_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700069F RID: 1695
			// (get) Token: 0x06001714 RID: 5908 RVA: 0x000587C4 File Offset: 0x000569C4
			// (set) Token: 0x06001715 RID: 5909 RVA: 0x0000CBF5 File Offset: 0x0000ADF5
			public unsafe Func<IEnumerator> beforeCommandBuilder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass32_0<T>.NativeFieldInfoPtr_beforeCommandBuilder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass32_0<T>.NativeFieldInfoPtr_beforeCommandBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006A0 RID: 1696
			// (get) Token: 0x06001716 RID: 5910 RVA: 0x000587F4 File Offset: 0x000569F4
			// (set) Token: 0x06001717 RID: 5911 RVA: 0x0000CC14 File Offset: 0x0000AE14
			public unsafe Func<IEnumerator> afterCommandBuilder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass32_0<T>.NativeFieldInfoPtr_afterCommandBuilder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass32_0<T>.NativeFieldInfoPtr_afterCommandBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DF4 RID: 3572
			private static readonly IntPtr NativeFieldInfoPtr_beforeCommandBuilder;

			// Token: 0x04000DF5 RID: 3573
			private static readonly IntPtr NativeFieldInfoPtr_afterCommandBuilder;

			// Token: 0x04000DF6 RID: 3574
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000DF7 RID: 3575
			private static readonly IntPtr NativeMethodInfoPtr__BookendFirst_b__0_Internal_IEnumerator_Command_0;

			// Token: 0x04000DF8 RID: 3576
			private static readonly IntPtr NativeMethodInfoPtr__BookendFirst_b__2_Internal_IEnumerator_Command_0;
		}

		// Token: 0x020001EA RID: 490
		[ObfuscatedName("zen.src.match.sequences.zenCommands.SequenceBuilder+<>c__DisplayClass34_0")]
		public sealed class __c__DisplayClass34_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06001718 RID: 5912 RVA: 0x00058824 File Offset: 0x00056A24
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass34_0()
			{
				Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, "<>c__DisplayClass34_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass34_0>.NativeClassPtr);
				SequenceBuilder.__c__DisplayClass34_0.NativeFieldInfoPtr_afterCommandBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass34_0>.NativeClassPtr, "afterCommandBuilder");
				SequenceBuilder.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass34_0>.NativeClassPtr, 100664169);
				SequenceBuilder.__c__DisplayClass34_0.NativeMethodInfoPtr__AddAfterAll_b__0_Internal_IEnumerator_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass34_0>.NativeClassPtr, 100664170);
			}

			// Token: 0x06001719 RID: 5913 RVA: 0x0005888C File Offset: 0x00056A8C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass34_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass34_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600171A RID: 5914 RVA: 0x000588C8 File Offset: 0x00056AC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _AddAfterAll_b__0(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass34_0.NativeMethodInfoPtr__AddAfterAll_b__0_Internal_IEnumerator_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x0600171B RID: 5915 RVA: 0x0000CC33 File Offset: 0x0000AE33
			public __c__DisplayClass34_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006A1 RID: 1697
			// (get) Token: 0x0600171C RID: 5916 RVA: 0x00058918 File Offset: 0x00056B18
			// (set) Token: 0x0600171D RID: 5917 RVA: 0x0000CC3C File Offset: 0x0000AE3C
			public unsafe Func<IEnumerator> afterCommandBuilder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass34_0.NativeFieldInfoPtr_afterCommandBuilder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass34_0.NativeFieldInfoPtr_afterCommandBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DF9 RID: 3577
			private static readonly IntPtr NativeFieldInfoPtr_afterCommandBuilder;

			// Token: 0x04000DFA RID: 3578
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000DFB RID: 3579
			private static readonly IntPtr NativeMethodInfoPtr__AddAfterAll_b__0_Internal_IEnumerator_Command_0;
		}

		// Token: 0x020001EB RID: 491
		[ObfuscatedName("zen.src.match.sequences.zenCommands.SequenceBuilder+<>c__DisplayClass35_0`1")]
		public sealed class __c__DisplayClass35_0<T> : global::Il2CppSystem.Object where T : Command
		{
			// Token: 0x0600171E RID: 5918 RVA: 0x00058948 File Offset: 0x00056B48
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass35_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, "<>c__DisplayClass35_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass35_0<T>>.NativeClassPtr);
				SequenceBuilder.__c__DisplayClass35_0<T>.NativeFieldInfoPtr_afterCommandBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass35_0<T>>.NativeClassPtr, "afterCommandBuilder");
				SequenceBuilder.__c__DisplayClass35_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass35_0<T>>.NativeClassPtr, 100664171);
				SequenceBuilder.__c__DisplayClass35_0<T>.NativeMethodInfoPtr__AddAfterAll_b__1_Internal_IEnumerator_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass35_0<T>>.NativeClassPtr, 100664172);
			}

			// Token: 0x0600171F RID: 5919 RVA: 0x000589EC File Offset: 0x00056BEC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass35_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass35_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001720 RID: 5920 RVA: 0x00058A28 File Offset: 0x00056C28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _AddAfterAll_b__1(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass35_0<T>.NativeMethodInfoPtr__AddAfterAll_b__1_Internal_IEnumerator_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x06001721 RID: 5921 RVA: 0x0000CC5B File Offset: 0x0000AE5B
			public __c__DisplayClass35_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006A2 RID: 1698
			// (get) Token: 0x06001722 RID: 5922 RVA: 0x00058A78 File Offset: 0x00056C78
			// (set) Token: 0x06001723 RID: 5923 RVA: 0x0000CC64 File Offset: 0x0000AE64
			public unsafe Func<T, IEnumerator> afterCommandBuilder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass35_0<T>.NativeFieldInfoPtr_afterCommandBuilder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass35_0<T>.NativeFieldInfoPtr_afterCommandBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DFC RID: 3580
			private static readonly IntPtr NativeFieldInfoPtr_afterCommandBuilder;

			// Token: 0x04000DFD RID: 3581
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000DFE RID: 3582
			private static readonly IntPtr NativeMethodInfoPtr__AddAfterAll_b__1_Internal_IEnumerator_Command_0;
		}

		// Token: 0x020001EC RID: 492
		[ObfuscatedName("zen.src.match.sequences.zenCommands.SequenceBuilder+<>c__DisplayClass36_0`1")]
		public sealed class __c__DisplayClass36_0<T> : global::Il2CppSystem.Object
		{
			// Token: 0x06001724 RID: 5924 RVA: 0x00058AA8 File Offset: 0x00056CA8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass36_0()
			{
				Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass36_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, "<>c__DisplayClass36_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass36_0<T>>.NativeClassPtr);
				SequenceBuilder.__c__DisplayClass36_0<T>.NativeFieldInfoPtr_afterCommandBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass36_0<T>>.NativeClassPtr, "afterCommandBuilder");
				SequenceBuilder.__c__DisplayClass36_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass36_0<T>>.NativeClassPtr, 100664173);
				SequenceBuilder.__c__DisplayClass36_0<T>.NativeMethodInfoPtr__AddAfterAll_b__1_Internal_IEnumerator_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass36_0<T>>.NativeClassPtr, 100664174);
			}

			// Token: 0x06001725 RID: 5925 RVA: 0x00058B4C File Offset: 0x00056D4C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass36_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass36_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass36_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001726 RID: 5926 RVA: 0x00058B88 File Offset: 0x00056D88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _AddAfterAll_b__1(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass36_0<T>.NativeMethodInfoPtr__AddAfterAll_b__1_Internal_IEnumerator_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x06001727 RID: 5927 RVA: 0x0000CC83 File Offset: 0x0000AE83
			public __c__DisplayClass36_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006A3 RID: 1699
			// (get) Token: 0x06001728 RID: 5928 RVA: 0x00058BD8 File Offset: 0x00056DD8
			// (set) Token: 0x06001729 RID: 5929 RVA: 0x0000CC8C File Offset: 0x0000AE8C
			public unsafe Func<IEnumerator> afterCommandBuilder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass36_0<T>.NativeFieldInfoPtr_afterCommandBuilder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass36_0<T>.NativeFieldInfoPtr_afterCommandBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DFF RID: 3583
			private static readonly IntPtr NativeFieldInfoPtr_afterCommandBuilder;

			// Token: 0x04000E00 RID: 3584
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000E01 RID: 3585
			private static readonly IntPtr NativeMethodInfoPtr__AddAfterAll_b__1_Internal_IEnumerator_Command_0;
		}

		// Token: 0x020001ED RID: 493
		[ObfuscatedName("zen.src.match.sequences.zenCommands.SequenceBuilder+<>c__DisplayClass38_0")]
		public sealed class __c__DisplayClass38_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600172A RID: 5930 RVA: 0x00058C08 File Offset: 0x00056E08
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass38_0()
			{
				Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass38_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, "<>c__DisplayClass38_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass38_0>.NativeClassPtr);
				SequenceBuilder.__c__DisplayClass38_0.NativeFieldInfoPtr_afterCommandBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass38_0>.NativeClassPtr, "afterCommandBuilder");
				SequenceBuilder.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass38_0>.NativeClassPtr, 100664175);
				SequenceBuilder.__c__DisplayClass38_0.NativeMethodInfoPtr__AddAfterFirst_b__0_Internal_IEnumerator_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass38_0>.NativeClassPtr, 100664176);
			}

			// Token: 0x0600172B RID: 5931 RVA: 0x00058C70 File Offset: 0x00056E70
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass38_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass38_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600172C RID: 5932 RVA: 0x00058CAC File Offset: 0x00056EAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _AddAfterFirst_b__0(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass38_0.NativeMethodInfoPtr__AddAfterFirst_b__0_Internal_IEnumerator_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x0600172D RID: 5933 RVA: 0x0000CCAB File Offset: 0x0000AEAB
			public __c__DisplayClass38_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006A4 RID: 1700
			// (get) Token: 0x0600172E RID: 5934 RVA: 0x00058CFC File Offset: 0x00056EFC
			// (set) Token: 0x0600172F RID: 5935 RVA: 0x0000CCB4 File Offset: 0x0000AEB4
			public unsafe Func<IEnumerator> afterCommandBuilder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass38_0.NativeFieldInfoPtr_afterCommandBuilder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass38_0.NativeFieldInfoPtr_afterCommandBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000E02 RID: 3586
			private static readonly IntPtr NativeFieldInfoPtr_afterCommandBuilder;

			// Token: 0x04000E03 RID: 3587
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000E04 RID: 3588
			private static readonly IntPtr NativeMethodInfoPtr__AddAfterFirst_b__0_Internal_IEnumerator_Command_0;
		}

		// Token: 0x020001EE RID: 494
		[ObfuscatedName("zen.src.match.sequences.zenCommands.SequenceBuilder+<>c__DisplayClass40_0`1")]
		public sealed class __c__DisplayClass40_0<T> : global::Il2CppSystem.Object
		{
			// Token: 0x06001730 RID: 5936 RVA: 0x00058D2C File Offset: 0x00056F2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass40_0()
			{
				Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass40_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, "<>c__DisplayClass40_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass40_0<T>>.NativeClassPtr);
				SequenceBuilder.__c__DisplayClass40_0<T>.NativeFieldInfoPtr_afterCommandBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass40_0<T>>.NativeClassPtr, "afterCommandBuilder");
				SequenceBuilder.__c__DisplayClass40_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass40_0<T>>.NativeClassPtr, 100664177);
				SequenceBuilder.__c__DisplayClass40_0<T>.NativeMethodInfoPtr__AddAfterFirst_b__1_Internal_IEnumerator_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass40_0<T>>.NativeClassPtr, 100664178);
			}

			// Token: 0x06001731 RID: 5937 RVA: 0x00058DD0 File Offset: 0x00056FD0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass40_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass40_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass40_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001732 RID: 5938 RVA: 0x00058E0C File Offset: 0x0005700C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _AddAfterFirst_b__1(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass40_0<T>.NativeMethodInfoPtr__AddAfterFirst_b__1_Internal_IEnumerator_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x06001733 RID: 5939 RVA: 0x0000CCD3 File Offset: 0x0000AED3
			public __c__DisplayClass40_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006A5 RID: 1701
			// (get) Token: 0x06001734 RID: 5940 RVA: 0x00058E5C File Offset: 0x0005705C
			// (set) Token: 0x06001735 RID: 5941 RVA: 0x0000CCDC File Offset: 0x0000AEDC
			public unsafe Func<IEnumerator> afterCommandBuilder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass40_0<T>.NativeFieldInfoPtr_afterCommandBuilder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass40_0<T>.NativeFieldInfoPtr_afterCommandBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000E05 RID: 3589
			private static readonly IntPtr NativeFieldInfoPtr_afterCommandBuilder;

			// Token: 0x04000E06 RID: 3590
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000E07 RID: 3591
			private static readonly IntPtr NativeMethodInfoPtr__AddAfterFirst_b__1_Internal_IEnumerator_Command_0;
		}

		// Token: 0x020001EF RID: 495
		[ObfuscatedName("zen.src.match.sequences.zenCommands.SequenceBuilder+<>c__DisplayClass42_0")]
		public sealed class __c__DisplayClass42_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06001736 RID: 5942 RVA: 0x00058E8C File Offset: 0x0005708C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass42_0()
			{
				Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass42_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, "<>c__DisplayClass42_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass42_0>.NativeClassPtr);
				SequenceBuilder.__c__DisplayClass42_0.NativeFieldInfoPtr_beforeCommandBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass42_0>.NativeClassPtr, "beforeCommandBuilder");
				SequenceBuilder.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass42_0>.NativeClassPtr, 100664179);
				SequenceBuilder.__c__DisplayClass42_0.NativeMethodInfoPtr__AddBeforeAll_b__0_Internal_IEnumerator_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass42_0>.NativeClassPtr, 100664180);
			}

			// Token: 0x06001737 RID: 5943 RVA: 0x00058EF4 File Offset: 0x000570F4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass42_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass42_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001738 RID: 5944 RVA: 0x00058F30 File Offset: 0x00057130
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _AddBeforeAll_b__0(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass42_0.NativeMethodInfoPtr__AddBeforeAll_b__0_Internal_IEnumerator_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x06001739 RID: 5945 RVA: 0x0000CCFB File Offset: 0x0000AEFB
			public __c__DisplayClass42_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006A6 RID: 1702
			// (get) Token: 0x0600173A RID: 5946 RVA: 0x00058F80 File Offset: 0x00057180
			// (set) Token: 0x0600173B RID: 5947 RVA: 0x0000CD04 File Offset: 0x0000AF04
			public unsafe Func<IEnumerator> beforeCommandBuilder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass42_0.NativeFieldInfoPtr_beforeCommandBuilder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass42_0.NativeFieldInfoPtr_beforeCommandBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000E08 RID: 3592
			private static readonly IntPtr NativeFieldInfoPtr_beforeCommandBuilder;

			// Token: 0x04000E09 RID: 3593
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000E0A RID: 3594
			private static readonly IntPtr NativeMethodInfoPtr__AddBeforeAll_b__0_Internal_IEnumerator_Command_0;
		}

		// Token: 0x020001F0 RID: 496
		[ObfuscatedName("zen.src.match.sequences.zenCommands.SequenceBuilder+<>c__DisplayClass43_0`1")]
		public sealed class __c__DisplayClass43_0<T> : global::Il2CppSystem.Object where T : Command
		{
			// Token: 0x0600173C RID: 5948 RVA: 0x00058FB0 File Offset: 0x000571B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass43_0()
			{
				Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass43_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, "<>c__DisplayClass43_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass43_0<T>>.NativeClassPtr);
				SequenceBuilder.__c__DisplayClass43_0<T>.NativeFieldInfoPtr_beforeCommandBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass43_0<T>>.NativeClassPtr, "beforeCommandBuilder");
				SequenceBuilder.__c__DisplayClass43_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass43_0<T>>.NativeClassPtr, 100664181);
				SequenceBuilder.__c__DisplayClass43_0<T>.NativeMethodInfoPtr__AddBeforeAll_b__0_Internal_IEnumerator_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass43_0<T>>.NativeClassPtr, 100664182);
			}

			// Token: 0x0600173D RID: 5949 RVA: 0x00059054 File Offset: 0x00057254
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass43_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass43_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass43_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600173E RID: 5950 RVA: 0x00059090 File Offset: 0x00057290
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _AddBeforeAll_b__0(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass43_0<T>.NativeMethodInfoPtr__AddBeforeAll_b__0_Internal_IEnumerator_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x0600173F RID: 5951 RVA: 0x0000CD23 File Offset: 0x0000AF23
			public __c__DisplayClass43_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006A7 RID: 1703
			// (get) Token: 0x06001740 RID: 5952 RVA: 0x000590E0 File Offset: 0x000572E0
			// (set) Token: 0x06001741 RID: 5953 RVA: 0x0000CD2C File Offset: 0x0000AF2C
			public unsafe Func<T, IEnumerator> beforeCommandBuilder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass43_0<T>.NativeFieldInfoPtr_beforeCommandBuilder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass43_0<T>.NativeFieldInfoPtr_beforeCommandBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000E0B RID: 3595
			private static readonly IntPtr NativeFieldInfoPtr_beforeCommandBuilder;

			// Token: 0x04000E0C RID: 3596
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000E0D RID: 3597
			private static readonly IntPtr NativeMethodInfoPtr__AddBeforeAll_b__0_Internal_IEnumerator_Command_0;
		}

		// Token: 0x020001F1 RID: 497
		[ObfuscatedName("zen.src.match.sequences.zenCommands.SequenceBuilder+<>c__DisplayClass44_0`1")]
		public sealed class __c__DisplayClass44_0<T> : global::Il2CppSystem.Object
		{
			// Token: 0x06001742 RID: 5954 RVA: 0x00059110 File Offset: 0x00057310
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass44_0()
			{
				Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass44_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, "<>c__DisplayClass44_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass44_0<T>>.NativeClassPtr);
				SequenceBuilder.__c__DisplayClass44_0<T>.NativeFieldInfoPtr_beforeCommandBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass44_0<T>>.NativeClassPtr, "beforeCommandBuilder");
				SequenceBuilder.__c__DisplayClass44_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass44_0<T>>.NativeClassPtr, 100664183);
				SequenceBuilder.__c__DisplayClass44_0<T>.NativeMethodInfoPtr__AddBeforeAll_b__0_Internal_IEnumerator_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass44_0<T>>.NativeClassPtr, 100664184);
			}

			// Token: 0x06001743 RID: 5955 RVA: 0x000591B4 File Offset: 0x000573B4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass44_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceBuilder.__c__DisplayClass44_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass44_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001744 RID: 5956 RVA: 0x000591F0 File Offset: 0x000573F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _AddBeforeAll_b__0(Command _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder.__c__DisplayClass44_0<T>.NativeMethodInfoPtr__AddBeforeAll_b__0_Internal_IEnumerator_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x06001745 RID: 5957 RVA: 0x0000CD4B File Offset: 0x0000AF4B
			public __c__DisplayClass44_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006A8 RID: 1704
			// (get) Token: 0x06001746 RID: 5958 RVA: 0x00059240 File Offset: 0x00057440
			// (set) Token: 0x06001747 RID: 5959 RVA: 0x0000CD54 File Offset: 0x0000AF54
			public unsafe Func<IEnumerator> beforeCommandBuilder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass44_0<T>.NativeFieldInfoPtr_beforeCommandBuilder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder.__c__DisplayClass44_0<T>.NativeFieldInfoPtr_beforeCommandBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000E0E RID: 3598
			private static readonly IntPtr NativeFieldInfoPtr_beforeCommandBuilder;

			// Token: 0x04000E0F RID: 3599
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000E10 RID: 3600
			private static readonly IntPtr NativeMethodInfoPtr__AddBeforeAll_b__0_Internal_IEnumerator_Command_0;
		}

		// Token: 0x020001F2 RID: 498
		[ObfuscatedName("zen.src.match.sequences.zenCommands.SequenceBuilder+<runInSeries>d__5")]
		public sealed class _runInSeries_d__5 : global::Il2CppSystem.Object
		{
			// Token: 0x06001748 RID: 5960 RVA: 0x00059270 File Offset: 0x00057470
			// Note: this type is marked as 'beforefieldinit'.
			static _runInSeries_d__5()
			{
				Il2CppClassPointerStore<SequenceBuilder._runInSeries_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr, "<runInSeries>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceBuilder._runInSeries_d__5>.NativeClassPtr);
				SequenceBuilder._runInSeries_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder._runInSeries_d__5>.NativeClassPtr, "<>1__state");
				SequenceBuilder._runInSeries_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder._runInSeries_d__5>.NativeClassPtr, "<>2__current");
				SequenceBuilder._runInSeries_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder._runInSeries_d__5>.NativeClassPtr, "<>4__this");
				SequenceBuilder._runInSeries_d__5.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceBuilder._runInSeries_d__5>.NativeClassPtr, "<>7__wrap1");
				SequenceBuilder._runInSeries_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder._runInSeries_d__5>.NativeClassPtr, 100664185);
				SequenceBuilder._runInSeries_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder._runInSeries_d__5>.NativeClassPtr, 100664186);
				SequenceBuilder._runInSeries_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder._runInSeries_d__5>.NativeClassPtr, 100664187);
				SequenceBuilder._runInSeries_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder._runInSeries_d__5>.NativeClassPtr, 100664188);
				SequenceBuilder._runInSeries_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder._runInSeries_d__5>.NativeClassPtr, 100664189);
				SequenceBuilder._runInSeries_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder._runInSeries_d__5>.NativeClassPtr, 100664190);
				SequenceBuilder._runInSeries_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceBuilder._runInSeries_d__5>.NativeClassPtr, 100664191);
			}

			// Token: 0x06001749 RID: 5961 RVA: 0x00059378 File Offset: 0x00057578
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _runInSeries_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceBuilder._runInSeries_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder._runInSeries_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600174A RID: 5962 RVA: 0x000593C0 File Offset: 0x000575C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987235, XrefRangeEnd = 987240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder._runInSeries_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600174B RID: 5963 RVA: 0x000593F4 File Offset: 0x000575F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987240, XrefRangeEnd = 987257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder._runInSeries_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600174C RID: 5964 RVA: 0x00059430 File Offset: 0x00057630
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987257, XrefRangeEnd = 987260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder._runInSeries_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006AD RID: 1709
			// (get) Token: 0x0600174D RID: 5965 RVA: 0x00059464 File Offset: 0x00057664
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder._runInSeries_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600174E RID: 5966 RVA: 0x000594A4 File Offset: 0x000576A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987260, XrefRangeEnd = 987265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder._runInSeries_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006AE RID: 1710
			// (get) Token: 0x0600174F RID: 5967 RVA: 0x000594D8 File Offset: 0x000576D8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceBuilder._runInSeries_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001750 RID: 5968 RVA: 0x0000CD73 File Offset: 0x0000AF73
			public _runInSeries_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006A9 RID: 1705
			// (get) Token: 0x06001751 RID: 5969 RVA: 0x00059518 File Offset: 0x00057718
			// (set) Token: 0x06001752 RID: 5970 RVA: 0x0000CD7C File Offset: 0x0000AF7C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder._runInSeries_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder._runInSeries_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006AA RID: 1706
			// (get) Token: 0x06001753 RID: 5971 RVA: 0x00059540 File Offset: 0x00057740
			// (set) Token: 0x06001754 RID: 5972 RVA: 0x0000CD97 File Offset: 0x0000AF97
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder._runInSeries_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder._runInSeries_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006AB RID: 1707
			// (get) Token: 0x06001755 RID: 5973 RVA: 0x00059570 File Offset: 0x00057770
			// (set) Token: 0x06001756 RID: 5974 RVA: 0x0000CDB6 File Offset: 0x0000AFB6
			public unsafe SequenceBuilder __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder._runInSeries_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder._runInSeries_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006AC RID: 1708
			// (get) Token: 0x06001757 RID: 5975 RVA: 0x000595A0 File Offset: 0x000577A0
			// (set) Token: 0x06001758 RID: 5976 RVA: 0x0000CDD5 File Offset: 0x0000AFD5
			public List<Command>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder._runInSeries_d__5.NativeFieldInfoPtr___7__wrap1);
					return new List<Command>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<Command>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceBuilder._runInSeries_d__5.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<Command>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000E11 RID: 3601
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000E12 RID: 3602
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000E13 RID: 3603
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000E14 RID: 3604
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04000E15 RID: 3605
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000E16 RID: 3606
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E17 RID: 3607
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000E18 RID: 3608
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000E19 RID: 3609
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000E1A RID: 3610
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E1B RID: 3611
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020001F3 RID: 499
		private sealed class MethodInfoStoreGeneric_First_Public_T_0<T>
		{
			// Token: 0x04000E1C RID: 3612
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SequenceBuilder.NativeMethodInfoPtr_First_Public_T_0, Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001F4 RID: 500
		private sealed class MethodInfoStoreGeneric_All_Public_IEnumerable_1_T_0<T>
		{
			// Token: 0x04000E1D RID: 3613
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SequenceBuilder.NativeMethodInfoPtr_All_Public_IEnumerable_1_T_0, Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001F5 RID: 501
		private sealed class MethodInfoStoreGeneric_WrapAll_Public_SequenceBuilder_Func_2_T_Command_0<T>
		{
			// Token: 0x04000E1E RID: 3614
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SequenceBuilder.NativeMethodInfoPtr_WrapAll_Public_SequenceBuilder_Func_2_T_Command_0, Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001F6 RID: 502
		private sealed class MethodInfoStoreGeneric_WrapFirst_Public_SequenceBuilder_Func_2_T_Command_0<T>
		{
			// Token: 0x04000E1F RID: 3615
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SequenceBuilder.NativeMethodInfoPtr_WrapFirst_Public_SequenceBuilder_Func_2_T_Command_0, Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001F7 RID: 503
		private sealed class MethodInfoStoreGeneric_WrapLast_Public_SequenceBuilder_Func_2_T_Command_0<T>
		{
			// Token: 0x04000E20 RID: 3616
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SequenceBuilder.NativeMethodInfoPtr_WrapLast_Public_SequenceBuilder_Func_2_T_Command_0, Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001F8 RID: 504
		private sealed class MethodInfoStoreGeneric_BookendAll_Public_SequenceBuilder_Func_2_Command_IEnumerator_Func_2_Command_IEnumerator_0<T>
		{
			// Token: 0x04000E21 RID: 3617
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SequenceBuilder.NativeMethodInfoPtr_BookendAll_Public_SequenceBuilder_Func_2_Command_IEnumerator_Func_2_Command_IEnumerator_0, Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001F9 RID: 505
		private sealed class MethodInfoStoreGeneric_BookendAll_Public_SequenceBuilder_Func_1_IEnumerator_Func_1_IEnumerator_0<T>
		{
			// Token: 0x04000E22 RID: 3618
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SequenceBuilder.NativeMethodInfoPtr_BookendAll_Public_SequenceBuilder_Func_1_IEnumerator_Func_1_IEnumerator_0, Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001FA RID: 506
		private sealed class MethodInfoStoreGeneric_BookendFirst_Public_SequenceBuilder_Func_2_T_IEnumerator_Func_2_T_IEnumerator_0<T>
		{
			// Token: 0x04000E23 RID: 3619
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SequenceBuilder.NativeMethodInfoPtr_BookendFirst_Public_SequenceBuilder_Func_2_T_IEnumerator_Func_2_T_IEnumerator_0, Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001FB RID: 507
		private sealed class MethodInfoStoreGeneric_BookendFirst_Public_SequenceBuilder_Func_1_IEnumerator_Func_1_IEnumerator_0<T>
		{
			// Token: 0x04000E24 RID: 3620
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SequenceBuilder.NativeMethodInfoPtr_BookendFirst_Public_SequenceBuilder_Func_1_IEnumerator_Func_1_IEnumerator_0, Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001FC RID: 508
		private sealed class MethodInfoStoreGeneric_AddAfterAll_Public_SequenceBuilder_Func_2_T_IEnumerator_0<T>
		{
			// Token: 0x04000E25 RID: 3621
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SequenceBuilder.NativeMethodInfoPtr_AddAfterAll_Public_SequenceBuilder_Func_2_T_IEnumerator_0, Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001FD RID: 509
		private sealed class MethodInfoStoreGeneric_AddAfterAll_Public_SequenceBuilder_Func_1_IEnumerator_0<T>
		{
			// Token: 0x04000E26 RID: 3622
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SequenceBuilder.NativeMethodInfoPtr_AddAfterAll_Public_SequenceBuilder_Func_1_IEnumerator_0, Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001FE RID: 510
		private sealed class MethodInfoStoreGeneric_AddAfterFirst_Public_SequenceBuilder_Func_2_T_IEnumerator_0<T>
		{
			// Token: 0x04000E27 RID: 3623
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SequenceBuilder.NativeMethodInfoPtr_AddAfterFirst_Public_SequenceBuilder_Func_2_T_IEnumerator_0, Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001FF RID: 511
		private sealed class MethodInfoStoreGeneric_AddAfterFirst_Public_SequenceBuilder_Func_1_IEnumerator_0<T>
		{
			// Token: 0x04000E28 RID: 3624
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SequenceBuilder.NativeMethodInfoPtr_AddAfterFirst_Public_SequenceBuilder_Func_1_IEnumerator_0, Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000200 RID: 512
		private sealed class MethodInfoStoreGeneric_AddBeforeAll_Public_SequenceBuilder_Func_2_T_IEnumerator_0<T>
		{
			// Token: 0x04000E29 RID: 3625
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SequenceBuilder.NativeMethodInfoPtr_AddBeforeAll_Public_SequenceBuilder_Func_2_T_IEnumerator_0, Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000201 RID: 513
		private sealed class MethodInfoStoreGeneric_AddBeforeAll_Public_SequenceBuilder_Func_1_IEnumerator_0<T>
		{
			// Token: 0x04000E2A RID: 3626
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SequenceBuilder.NativeMethodInfoPtr_AddBeforeAll_Public_SequenceBuilder_Func_1_IEnumerator_0, Il2CppClassPointerStore<SequenceBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
