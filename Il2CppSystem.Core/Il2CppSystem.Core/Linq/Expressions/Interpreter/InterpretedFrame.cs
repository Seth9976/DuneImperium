using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000BF RID: 191
	public sealed class InterpretedFrame : Object
	{
		// Token: 0x06000B26 RID: 2854 RVA: 0x0003F0C4 File Offset: 0x0003D2C4
		// Note: this type is marked as 'beforefieldinit'.
		static InterpretedFrame()
		{
			Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "InterpretedFrame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr);
			InterpretedFrame.NativeFieldInfoPtr_s_currentFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, "s_currentFrame");
			InterpretedFrame.NativeFieldInfoPtr_Interpreter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, "Interpreter");
			InterpretedFrame.NativeFieldInfoPtr__parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, "_parent");
			InterpretedFrame.NativeFieldInfoPtr__continuations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, "_continuations");
			InterpretedFrame.NativeFieldInfoPtr__continuationIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, "_continuationIndex");
			InterpretedFrame.NativeFieldInfoPtr__pendingContinuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, "_pendingContinuation");
			InterpretedFrame.NativeFieldInfoPtr__pendingValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, "_pendingValue");
			InterpretedFrame.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, "Data");
			InterpretedFrame.NativeFieldInfoPtr_Closure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, "Closure");
			InterpretedFrame.NativeFieldInfoPtr_StackIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, "StackIndex");
			InterpretedFrame.NativeFieldInfoPtr_InstructionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, "InstructionIndex");
			InterpretedFrame.NativeMethodInfoPtr__ctor_Internal_Void_Interpreter_Il2CppReferenceArray_1_IStrongBox_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, 100665378);
			InterpretedFrame.NativeMethodInfoPtr_GetDebugInfo_Public_DebugInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, 100665379);
			InterpretedFrame.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, 100665380);
			InterpretedFrame.NativeMethodInfoPtr_Push_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, 100665381);
			InterpretedFrame.NativeMethodInfoPtr_Push_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, 100665382);
			InterpretedFrame.NativeMethodInfoPtr_Push_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, 100665383);
			InterpretedFrame.NativeMethodInfoPtr_Push_Public_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, 100665384);
			InterpretedFrame.NativeMethodInfoPtr_Push_Public_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, 100665385);
			InterpretedFrame.NativeMethodInfoPtr_Push_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, 100665386);
			InterpretedFrame.NativeMethodInfoPtr_Push_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, 100665387);
			InterpretedFrame.NativeMethodInfoPtr_Pop_Public_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, 100665388);
			InterpretedFrame.NativeMethodInfoPtr_SetStackDepth_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, 100665389);
			InterpretedFrame.NativeMethodInfoPtr_Peek_Public_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, 100665390);
			InterpretedFrame.NativeMethodInfoPtr_Dup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, 100665391);
			InterpretedFrame.NativeMethodInfoPtr_get_Parent_Public_get_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, 100665392);
			InterpretedFrame.NativeMethodInfoPtr_GetStackTraceDebugInfo_Public_IEnumerable_1_InterpretedFrameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, 100665393);
			InterpretedFrame.NativeMethodInfoPtr_SaveTraceToException_Internal_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, 100665394);
			InterpretedFrame.NativeMethodInfoPtr_Enter_Internal_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, 100665395);
			InterpretedFrame.NativeMethodInfoPtr_Leave_Internal_Void_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, 100665396);
			InterpretedFrame.NativeMethodInfoPtr_IsJumpHappened_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, 100665397);
			InterpretedFrame.NativeMethodInfoPtr_RemoveContinuation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, 100665398);
			InterpretedFrame.NativeMethodInfoPtr_PushContinuation_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, 100665399);
			InterpretedFrame.NativeMethodInfoPtr_YieldToCurrentContinuation_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, 100665400);
			InterpretedFrame.NativeMethodInfoPtr_YieldToPendingContinuation_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, 100665401);
			InterpretedFrame.NativeMethodInfoPtr_PushPendingContinuation_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, 100665402);
			InterpretedFrame.NativeMethodInfoPtr_PopPendingContinuation_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, 100665403);
			InterpretedFrame.NativeMethodInfoPtr_Goto_Public_Int32_Int32_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, 100665404);
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x0003F3EC File Offset: 0x0003D5EC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1018643, RefRangeEnd = 1018647, XrefRangeStart = 1018626, XrefRangeEnd = 1018643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InterpretedFrame(Interpreter interpreter, Il2CppReferenceArray<IStrongBox> closure)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(interpreter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(closure);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame.NativeMethodInfoPtr__ctor_Internal_Void_Interpreter_Il2CppReferenceArray_1_IStrongBox_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x0003F44C File Offset: 0x0003D64C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018647, XrefRangeEnd = 1018661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugInfo GetDebugInfo(int instructionIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instructionIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame.NativeMethodInfoPtr_GetDebugInfo_Public_DebugInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x0003F498 File Offset: 0x0003D698
		public unsafe string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x0003F4D0 File Offset: 0x0003D6D0
		[CallerCount(69)]
		[CachedScanResults(RefRangeStart = 1018667, RefRangeEnd = 1018736, XrefRangeStart = 1018661, XrefRangeEnd = 1018667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame.NativeMethodInfoPtr_Push_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x0003F514 File Offset: 0x0003D714
		[CallerCount(104)]
		[CachedScanResults(RefRangeStart = 1018749, RefRangeEnd = 1018853, XrefRangeStart = 1018736, XrefRangeEnd = 1018749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame.NativeMethodInfoPtr_Push_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x0003F554 File Offset: 0x0003D754
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1018860, RefRangeEnd = 1018872, XrefRangeStart = 1018853, XrefRangeEnd = 1018860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame.NativeMethodInfoPtr_Push_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x0003F594 File Offset: 0x0003D794
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1018877, RefRangeEnd = 1018883, XrefRangeStart = 1018872, XrefRangeEnd = 1018877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push(byte value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame.NativeMethodInfoPtr_Push_Public_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x0003F5D4 File Offset: 0x0003D7D4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1018888, RefRangeEnd = 1018893, XrefRangeStart = 1018883, XrefRangeEnd = 1018888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push(sbyte value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame.NativeMethodInfoPtr_Push_Public_Void_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x0003F614 File Offset: 0x0003D814
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1018898, RefRangeEnd = 1018908, XrefRangeStart = 1018893, XrefRangeEnd = 1018898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push(short value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame.NativeMethodInfoPtr_Push_Public_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x0003F654 File Offset: 0x0003D854
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1018913, RefRangeEnd = 1018921, XrefRangeStart = 1018908, XrefRangeEnd = 1018913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push(ushort value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame.NativeMethodInfoPtr_Push_Public_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x0003F694 File Offset: 0x0003D894
		[CallerCount(236)]
		[CachedScanResults(RefRangeStart = 1018921, RefRangeEnd = 1019157, XrefRangeStart = 1018921, XrefRangeEnd = 1018921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame.NativeMethodInfoPtr_Pop_Public_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x0003F6D4 File Offset: 0x0003D8D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1019157, RefRangeEnd = 1019159, XrefRangeStart = 1019157, XrefRangeEnd = 1019157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStackDepth(int depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame.NativeMethodInfoPtr_SetStackDepth_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x0003F714 File Offset: 0x0003D914
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1019159, RefRangeEnd = 1019166, XrefRangeStart = 1019159, XrefRangeEnd = 1019159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame.NativeMethodInfoPtr_Peek_Public_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x0003F754 File Offset: 0x0003D954
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1019168, RefRangeEnd = 1019169, XrefRangeStart = 1019166, XrefRangeEnd = 1019168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame.NativeMethodInfoPtr_Dup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x0003F788 File Offset: 0x0003D988
		public unsafe InterpretedFrame Parent
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame.NativeMethodInfoPtr_get_Parent_Public_get_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InterpretedFrame>(intPtr3) : null;
			}
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x0003F7C8 File Offset: 0x0003D9C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019169, XrefRangeEnd = 1019175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<InterpretedFrameInfo> GetStackTraceDebugInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame.NativeMethodInfoPtr_GetStackTraceDebugInfo_Public_IEnumerable_1_InterpretedFrameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<InterpretedFrameInfo>>(intPtr3) : null;
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x0003F808 File Offset: 0x0003DA08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1019205, RefRangeEnd = 1019206, XrefRangeStart = 1019175, XrefRangeEnd = 1019205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveTraceToException(Exception exception)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame.NativeMethodInfoPtr_SaveTraceToException_Internal_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x0003F84C File Offset: 0x0003DA4C
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 1019215, RefRangeEnd = 1019250, XrefRangeStart = 1019206, XrefRangeEnd = 1019215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InterpretedFrame Enter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame.NativeMethodInfoPtr_Enter_Internal_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InterpretedFrame>(intPtr3) : null;
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x0003F88C File Offset: 0x0003DA8C
		[CallerCount(64)]
		[CachedScanResults(RefRangeStart = 1019256, RefRangeEnd = 1019320, XrefRangeStart = 1019250, XrefRangeEnd = 1019256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Leave(InterpretedFrame prevFrame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prevFrame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame.NativeMethodInfoPtr_Leave_Internal_Void_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x0003F8D0 File Offset: 0x0003DAD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1019320, RefRangeEnd = 1019322, XrefRangeStart = 1019320, XrefRangeEnd = 1019320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsJumpHappened()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame.NativeMethodInfoPtr_IsJumpHappened_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x0003F90C File Offset: 0x0003DB0C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 336300, RefRangeEnd = 336304, XrefRangeStart = 336300, XrefRangeEnd = 336304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveContinuation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame.NativeMethodInfoPtr_RemoveContinuation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x0003F940 File Offset: 0x0003DB40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1019322, RefRangeEnd = 1019324, XrefRangeStart = 1019322, XrefRangeEnd = 1019322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushContinuation(int continuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref continuation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame.NativeMethodInfoPtr_PushContinuation_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x0003F980 File Offset: 0x0003DB80
		[CallerCount(0)]
		public unsafe int YieldToCurrentContinuation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame.NativeMethodInfoPtr_YieldToCurrentContinuation_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x0003F9BC File Offset: 0x0003DBBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1019334, RefRangeEnd = 1019335, XrefRangeStart = 1019324, XrefRangeEnd = 1019334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int YieldToPendingContinuation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame.NativeMethodInfoPtr_YieldToPendingContinuation_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x0003F9F8 File Offset: 0x0003DBF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1019347, RefRangeEnd = 1019349, XrefRangeStart = 1019335, XrefRangeEnd = 1019347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushPendingContinuation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame.NativeMethodInfoPtr_PushPendingContinuation_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x0003FA2C File Offset: 0x0003DC2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1019353, RefRangeEnd = 1019355, XrefRangeStart = 1019349, XrefRangeEnd = 1019353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopPendingContinuation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame.NativeMethodInfoPtr_PopPendingContinuation_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x0003FA60 File Offset: 0x0003DC60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1019357, RefRangeEnd = 1019359, XrefRangeStart = 1019355, XrefRangeEnd = 1019357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Goto(int labelIndex, Object value, bool gotoExceptionHandler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref labelIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gotoExceptionHandler;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame.NativeMethodInfoPtr_Goto_Public_Int32_Int32_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x000052BD File Offset: 0x000034BD
		public InterpretedFrame(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x0003FACC File Offset: 0x0003DCCC
		// (set) Token: 0x06000B44 RID: 2884 RVA: 0x000052C6 File Offset: 0x000034C6
		public unsafe static InterpretedFrame s_currentFrame
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InterpretedFrame.NativeFieldInfoPtr_s_currentFrame, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InterpretedFrame>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InterpretedFrame.NativeFieldInfoPtr_s_currentFrame, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x0003FAF4 File Offset: 0x0003DCF4
		// (set) Token: 0x06000B46 RID: 2886 RVA: 0x000052D8 File Offset: 0x000034D8
		public unsafe Interpreter Interpreter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrame.NativeFieldInfoPtr_Interpreter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Interpreter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrame.NativeFieldInfoPtr_Interpreter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x0003FB24 File Offset: 0x0003DD24
		// (set) Token: 0x06000B48 RID: 2888 RVA: 0x000052F7 File Offset: 0x000034F7
		public unsafe InterpretedFrame _parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrame.NativeFieldInfoPtr__parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InterpretedFrame>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrame.NativeFieldInfoPtr__parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x0003FB54 File Offset: 0x0003DD54
		// (set) Token: 0x06000B4A RID: 2890 RVA: 0x00005316 File Offset: 0x00003516
		public unsafe Il2CppStructArray<int> _continuations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrame.NativeFieldInfoPtr__continuations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrame.NativeFieldInfoPtr__continuations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x0003FB84 File Offset: 0x0003DD84
		// (set) Token: 0x06000B4C RID: 2892 RVA: 0x00005335 File Offset: 0x00003535
		public unsafe int _continuationIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrame.NativeFieldInfoPtr__continuationIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrame.NativeFieldInfoPtr__continuationIndex)) = value;
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000B4D RID: 2893 RVA: 0x0003FBAC File Offset: 0x0003DDAC
		// (set) Token: 0x06000B4E RID: 2894 RVA: 0x00005350 File Offset: 0x00003550
		public unsafe int _pendingContinuation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrame.NativeFieldInfoPtr__pendingContinuation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrame.NativeFieldInfoPtr__pendingContinuation)) = value;
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000B4F RID: 2895 RVA: 0x0003FBD4 File Offset: 0x0003DDD4
		// (set) Token: 0x06000B50 RID: 2896 RVA: 0x0000536B File Offset: 0x0000356B
		public unsafe Object _pendingValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrame.NativeFieldInfoPtr__pendingValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrame.NativeFieldInfoPtr__pendingValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000B51 RID: 2897 RVA: 0x0003FC04 File Offset: 0x0003DE04
		// (set) Token: 0x06000B52 RID: 2898 RVA: 0x0000538A File Offset: 0x0000358A
		public unsafe Il2CppReferenceArray<Object> Data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrame.NativeFieldInfoPtr_Data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrame.NativeFieldInfoPtr_Data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000B53 RID: 2899 RVA: 0x0003FC34 File Offset: 0x0003DE34
		// (set) Token: 0x06000B54 RID: 2900 RVA: 0x000053A9 File Offset: 0x000035A9
		public unsafe Il2CppReferenceArray<IStrongBox> Closure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrame.NativeFieldInfoPtr_Closure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IStrongBox>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrame.NativeFieldInfoPtr_Closure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000B55 RID: 2901 RVA: 0x0003FC64 File Offset: 0x0003DE64
		// (set) Token: 0x06000B56 RID: 2902 RVA: 0x000053C8 File Offset: 0x000035C8
		public unsafe int StackIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrame.NativeFieldInfoPtr_StackIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrame.NativeFieldInfoPtr_StackIndex)) = value;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000B57 RID: 2903 RVA: 0x0003FC8C File Offset: 0x0003DE8C
		// (set) Token: 0x06000B58 RID: 2904 RVA: 0x000053E3 File Offset: 0x000035E3
		public unsafe int InstructionIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrame.NativeFieldInfoPtr_InstructionIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrame.NativeFieldInfoPtr_InstructionIndex)) = value;
			}
		}

		// Token: 0x04000851 RID: 2129
		private static readonly IntPtr NativeFieldInfoPtr_s_currentFrame;

		// Token: 0x04000852 RID: 2130
		private static readonly IntPtr NativeFieldInfoPtr_Interpreter;

		// Token: 0x04000853 RID: 2131
		private static readonly IntPtr NativeFieldInfoPtr__parent;

		// Token: 0x04000854 RID: 2132
		private static readonly IntPtr NativeFieldInfoPtr__continuations;

		// Token: 0x04000855 RID: 2133
		private static readonly IntPtr NativeFieldInfoPtr__continuationIndex;

		// Token: 0x04000856 RID: 2134
		private static readonly IntPtr NativeFieldInfoPtr__pendingContinuation;

		// Token: 0x04000857 RID: 2135
		private static readonly IntPtr NativeFieldInfoPtr__pendingValue;

		// Token: 0x04000858 RID: 2136
		private static readonly IntPtr NativeFieldInfoPtr_Data;

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeFieldInfoPtr_Closure;

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeFieldInfoPtr_StackIndex;

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeFieldInfoPtr_InstructionIndex;

		// Token: 0x0400085C RID: 2140
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Interpreter_Il2CppReferenceArray_1_IStrongBox_0;

		// Token: 0x0400085D RID: 2141
		private static readonly IntPtr NativeMethodInfoPtr_GetDebugInfo_Public_DebugInfo_Int32_0;

		// Token: 0x0400085E RID: 2142
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x0400085F RID: 2143
		private static readonly IntPtr NativeMethodInfoPtr_Push_Public_Void_Object_0;

		// Token: 0x04000860 RID: 2144
		private static readonly IntPtr NativeMethodInfoPtr_Push_Public_Void_Boolean_0;

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeMethodInfoPtr_Push_Public_Void_Int32_0;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeMethodInfoPtr_Push_Public_Void_Byte_0;

		// Token: 0x04000863 RID: 2147
		private static readonly IntPtr NativeMethodInfoPtr_Push_Public_Void_SByte_0;

		// Token: 0x04000864 RID: 2148
		private static readonly IntPtr NativeMethodInfoPtr_Push_Public_Void_Int16_0;

		// Token: 0x04000865 RID: 2149
		private static readonly IntPtr NativeMethodInfoPtr_Push_Public_Void_UInt16_0;

		// Token: 0x04000866 RID: 2150
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Public_Object_0;

		// Token: 0x04000867 RID: 2151
		private static readonly IntPtr NativeMethodInfoPtr_SetStackDepth_Internal_Void_Int32_0;

		// Token: 0x04000868 RID: 2152
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_Object_0;

		// Token: 0x04000869 RID: 2153
		private static readonly IntPtr NativeMethodInfoPtr_Dup_Public_Void_0;

		// Token: 0x0400086A RID: 2154
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_get_InterpretedFrame_0;

		// Token: 0x0400086B RID: 2155
		private static readonly IntPtr NativeMethodInfoPtr_GetStackTraceDebugInfo_Public_IEnumerable_1_InterpretedFrameInfo_0;

		// Token: 0x0400086C RID: 2156
		private static readonly IntPtr NativeMethodInfoPtr_SaveTraceToException_Internal_Void_Exception_0;

		// Token: 0x0400086D RID: 2157
		private static readonly IntPtr NativeMethodInfoPtr_Enter_Internal_InterpretedFrame_0;

		// Token: 0x0400086E RID: 2158
		private static readonly IntPtr NativeMethodInfoPtr_Leave_Internal_Void_InterpretedFrame_0;

		// Token: 0x0400086F RID: 2159
		private static readonly IntPtr NativeMethodInfoPtr_IsJumpHappened_Internal_Boolean_0;

		// Token: 0x04000870 RID: 2160
		private static readonly IntPtr NativeMethodInfoPtr_RemoveContinuation_Public_Void_0;

		// Token: 0x04000871 RID: 2161
		private static readonly IntPtr NativeMethodInfoPtr_PushContinuation_Public_Void_Int32_0;

		// Token: 0x04000872 RID: 2162
		private static readonly IntPtr NativeMethodInfoPtr_YieldToCurrentContinuation_Public_Int32_0;

		// Token: 0x04000873 RID: 2163
		private static readonly IntPtr NativeMethodInfoPtr_YieldToPendingContinuation_Public_Int32_0;

		// Token: 0x04000874 RID: 2164
		private static readonly IntPtr NativeMethodInfoPtr_PushPendingContinuation_Internal_Void_0;

		// Token: 0x04000875 RID: 2165
		private static readonly IntPtr NativeMethodInfoPtr_PopPendingContinuation_Internal_Void_0;

		// Token: 0x04000876 RID: 2166
		private static readonly IntPtr NativeMethodInfoPtr_Goto_Public_Int32_Int32_Object_Boolean_0;

		// Token: 0x02000251 RID: 593
		[ObfuscatedName("System.Linq.Expressions.Interpreter.InterpretedFrame+<GetStackTraceDebugInfo>d__29")]
		public sealed class _GetStackTraceDebugInfo_d__29 : Object
		{
			// Token: 0x06001813 RID: 6163 RVA: 0x00073CB0 File Offset: 0x00071EB0
			// Note: this type is marked as 'beforefieldinit'.
			static _GetStackTraceDebugInfo_d__29()
			{
				Il2CppClassPointerStore<InterpretedFrame._GetStackTraceDebugInfo_d__29>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InterpretedFrame>.NativeClassPtr, "<GetStackTraceDebugInfo>d__29");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InterpretedFrame._GetStackTraceDebugInfo_d__29>.NativeClassPtr);
				InterpretedFrame._GetStackTraceDebugInfo_d__29.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterpretedFrame._GetStackTraceDebugInfo_d__29>.NativeClassPtr, "<>1__state");
				InterpretedFrame._GetStackTraceDebugInfo_d__29.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterpretedFrame._GetStackTraceDebugInfo_d__29>.NativeClassPtr, "<>2__current");
				InterpretedFrame._GetStackTraceDebugInfo_d__29.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterpretedFrame._GetStackTraceDebugInfo_d__29>.NativeClassPtr, "<>l__initialThreadId");
				InterpretedFrame._GetStackTraceDebugInfo_d__29.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterpretedFrame._GetStackTraceDebugInfo_d__29>.NativeClassPtr, "<>4__this");
				InterpretedFrame._GetStackTraceDebugInfo_d__29.NativeFieldInfoPtr__frame_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterpretedFrame._GetStackTraceDebugInfo_d__29>.NativeClassPtr, "<frame>5__2");
				InterpretedFrame._GetStackTraceDebugInfo_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame._GetStackTraceDebugInfo_d__29>.NativeClassPtr, 100665405);
				InterpretedFrame._GetStackTraceDebugInfo_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame._GetStackTraceDebugInfo_d__29>.NativeClassPtr, 100665406);
				InterpretedFrame._GetStackTraceDebugInfo_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame._GetStackTraceDebugInfo_d__29>.NativeClassPtr, 100665407);
				InterpretedFrame._GetStackTraceDebugInfo_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Linq_Expressions_Interpreter_InterpretedFrameInfo__get_Current_Private_Virtual_Final_New_get_InterpretedFrameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame._GetStackTraceDebugInfo_d__29>.NativeClassPtr, 100665408);
				InterpretedFrame._GetStackTraceDebugInfo_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame._GetStackTraceDebugInfo_d__29>.NativeClassPtr, 100665409);
				InterpretedFrame._GetStackTraceDebugInfo_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame._GetStackTraceDebugInfo_d__29>.NativeClassPtr, 100665410);
				InterpretedFrame._GetStackTraceDebugInfo_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Linq_Expressions_Interpreter_InterpretedFrameInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_InterpretedFrameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame._GetStackTraceDebugInfo_d__29>.NativeClassPtr, 100665411);
				InterpretedFrame._GetStackTraceDebugInfo_d__29.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterpretedFrame._GetStackTraceDebugInfo_d__29>.NativeClassPtr, 100665412);
			}

			// Token: 0x06001814 RID: 6164 RVA: 0x00073DE0 File Offset: 0x00071FE0
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetStackTraceDebugInfo_d__29(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InterpretedFrame._GetStackTraceDebugInfo_d__29>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame._GetStackTraceDebugInfo_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001815 RID: 6165 RVA: 0x00073E28 File Offset: 0x00072028
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame._GetStackTraceDebugInfo_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001816 RID: 6166 RVA: 0x00073E5C File Offset: 0x0007205C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018595, XrefRangeEnd = 1018616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame._GetStackTraceDebugInfo_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170006AE RID: 1710
			// (get) Token: 0x06001817 RID: 6167 RVA: 0x00073E98 File Offset: 0x00072098
			public unsafe InterpretedFrameInfo System.Collections.Generic.IEnumerator<System.Linq.Expressions.Interpreter.InterpretedFrameInfo>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame._GetStackTraceDebugInfo_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Linq_Expressions_Interpreter_InterpretedFrameInfo__get_Current_Private_Virtual_Final_New_get_InterpretedFrameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new InterpretedFrameInfo(intPtr);
				}
			}

			// Token: 0x06001818 RID: 6168 RVA: 0x00073ED0 File Offset: 0x000720D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018616, XrefRangeEnd = 1018621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame._GetStackTraceDebugInfo_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006AF RID: 1711
			// (get) Token: 0x06001819 RID: 6169 RVA: 0x00073F04 File Offset: 0x00072104
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018621, XrefRangeEnd = 1018624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame._GetStackTraceDebugInfo_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600181A RID: 6170 RVA: 0x00073F44 File Offset: 0x00072144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018624, XrefRangeEnd = 1018626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<InterpretedFrameInfo> System_Collections_Generic_IEnumerable_System_Linq_Expressions_Interpreter_InterpretedFrameInfo__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame._GetStackTraceDebugInfo_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Linq_Expressions_Interpreter_InterpretedFrameInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_InterpretedFrameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<InterpretedFrameInfo>>(intPtr3) : null;
			}

			// Token: 0x0600181B RID: 6171 RVA: 0x00073F84 File Offset: 0x00072184
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterpretedFrame._GetStackTraceDebugInfo_d__29.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600181C RID: 6172 RVA: 0x00009C72 File Offset: 0x00007E72
			public _GetStackTraceDebugInfo_d__29(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006A9 RID: 1705
			// (get) Token: 0x0600181D RID: 6173 RVA: 0x00073FC4 File Offset: 0x000721C4
			// (set) Token: 0x0600181E RID: 6174 RVA: 0x00009C7B File Offset: 0x00007E7B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrame._GetStackTraceDebugInfo_d__29.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrame._GetStackTraceDebugInfo_d__29.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006AA RID: 1706
			// (get) Token: 0x0600181F RID: 6175 RVA: 0x00073FEC File Offset: 0x000721EC
			// (set) Token: 0x06001820 RID: 6176 RVA: 0x00009C96 File Offset: 0x00007E96
			public InterpretedFrameInfo __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrame._GetStackTraceDebugInfo_d__29.NativeFieldInfoPtr___2__current);
					return new InterpretedFrameInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InterpretedFrameInfo>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrame._GetStackTraceDebugInfo_d__29.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InterpretedFrameInfo>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006AB RID: 1707
			// (get) Token: 0x06001821 RID: 6177 RVA: 0x0007401C File Offset: 0x0007221C
			// (set) Token: 0x06001822 RID: 6178 RVA: 0x00009CC4 File Offset: 0x00007EC4
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrame._GetStackTraceDebugInfo_d__29.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrame._GetStackTraceDebugInfo_d__29.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170006AC RID: 1708
			// (get) Token: 0x06001823 RID: 6179 RVA: 0x00074044 File Offset: 0x00072244
			// (set) Token: 0x06001824 RID: 6180 RVA: 0x00009CDF File Offset: 0x00007EDF
			public unsafe InterpretedFrame __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrame._GetStackTraceDebugInfo_d__29.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InterpretedFrame>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrame._GetStackTraceDebugInfo_d__29.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006AD RID: 1709
			// (get) Token: 0x06001825 RID: 6181 RVA: 0x00074074 File Offset: 0x00072274
			// (set) Token: 0x06001826 RID: 6182 RVA: 0x00009CFE File Offset: 0x00007EFE
			public unsafe InterpretedFrame _frame_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrame._GetStackTraceDebugInfo_d__29.NativeFieldInfoPtr__frame_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InterpretedFrame>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InterpretedFrame._GetStackTraceDebugInfo_d__29.NativeFieldInfoPtr__frame_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400109B RID: 4251
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400109C RID: 4252
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400109D RID: 4253
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400109E RID: 4254
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400109F RID: 4255
			private static readonly IntPtr NativeFieldInfoPtr__frame_5__2;

			// Token: 0x040010A0 RID: 4256
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040010A1 RID: 4257
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040010A2 RID: 4258
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040010A3 RID: 4259
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Linq_Expressions_Interpreter_InterpretedFrameInfo__get_Current_Private_Virtual_Final_New_get_InterpretedFrameInfo_0;

			// Token: 0x040010A4 RID: 4260
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040010A5 RID: 4261
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040010A6 RID: 4262
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Linq_Expressions_Interpreter_InterpretedFrameInfo__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_InterpretedFrameInfo_0;

			// Token: 0x040010A7 RID: 4263
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
