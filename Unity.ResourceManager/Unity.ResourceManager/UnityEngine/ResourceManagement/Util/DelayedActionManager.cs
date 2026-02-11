using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.ResourceManagement.Util
{
	// Token: 0x02000016 RID: 22
	public class DelayedActionManager : ComponentSingleton<DelayedActionManager>
	{
		// Token: 0x0600016E RID: 366 RVA: 0x0000AB24 File Offset: 0x00008D24
		// Note: this type is marked as 'beforefieldinit'.
		static DelayedActionManager()
		{
			Il2CppClassPointerStore<DelayedActionManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.Util", "DelayedActionManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelayedActionManager>.NativeClassPtr);
			DelayedActionManager.NativeFieldInfoPtr_m_Actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedActionManager>.NativeClassPtr, "m_Actions");
			DelayedActionManager.NativeFieldInfoPtr_m_DelayedActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedActionManager>.NativeClassPtr, "m_DelayedActions");
			DelayedActionManager.NativeFieldInfoPtr_m_NodeCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedActionManager>.NativeClassPtr, "m_NodeCache");
			DelayedActionManager.NativeFieldInfoPtr_m_CollectionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedActionManager>.NativeClassPtr, "m_CollectionIndex");
			DelayedActionManager.NativeFieldInfoPtr_m_DestroyOnCompletion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedActionManager>.NativeClassPtr, "m_DestroyOnCompletion");
			DelayedActionManager.NativeMethodInfoPtr_GetNode_Private_LinkedListNode_1_DelegateInfo_byref_DelegateInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedActionManager>.NativeClassPtr, 100663574);
			DelayedActionManager.NativeMethodInfoPtr_Clear_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedActionManager>.NativeClassPtr, 100663575);
			DelayedActionManager.NativeMethodInfoPtr_DestroyWhenComplete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedActionManager>.NativeClassPtr, 100663576);
			DelayedActionManager.NativeMethodInfoPtr_AddAction_Public_Static_Void_Delegate_Single_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedActionManager>.NativeClassPtr, 100663577);
			DelayedActionManager.NativeMethodInfoPtr_AddActionInternal_Private_Void_Delegate_Single_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedActionManager>.NativeClassPtr, 100663578);
			DelayedActionManager.NativeMethodInfoPtr_get_IsActive_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedActionManager>.NativeClassPtr, 100663579);
			DelayedActionManager.NativeMethodInfoPtr_Wait_Public_Static_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedActionManager>.NativeClassPtr, 100663580);
			DelayedActionManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedActionManager>.NativeClassPtr, 100663581);
			DelayedActionManager.NativeMethodInfoPtr_InternalLateUpdate_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedActionManager>.NativeClassPtr, 100663582);
			DelayedActionManager.NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedActionManager>.NativeClassPtr, 100663583);
			DelayedActionManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedActionManager>.NativeClassPtr, 100663584);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000AC94 File Offset: 0x00008E94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1138439, RefRangeEnd = 1138440, XrefRangeStart = 1138430, XrefRangeEnd = 1138439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LinkedListNode<DelayedActionManager.DelegateInfo> GetNode(ref DelayedActionManager.DelegateInfo del)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(del);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedActionManager.NativeMethodInfoPtr_GetNode_Private_LinkedListNode_1_DelegateInfo_byref_DelegateInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LinkedListNode<DelayedActionManager.DelegateInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000ACE8 File Offset: 0x00008EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138440, XrefRangeEnd = 1138446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Clear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedActionManager.NativeMethodInfoPtr_Clear_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000AD10 File Offset: 0x00008F10
		[CallerCount(0)]
		public unsafe void DestroyWhenComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedActionManager.NativeMethodInfoPtr_DestroyWhenComplete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000AD44 File Offset: 0x00008F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138446, XrefRangeEnd = 1138450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddAction(Delegate action, float delay = 0f, [Optional] Il2CppReferenceArray<Object> parameters)
		{
			if (parameters == null)
			{
				parameters = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedActionManager.NativeMethodInfoPtr_AddAction_Public_Static_Void_Delegate_Single_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000ADA8 File Offset: 0x00008FA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1138474, RefRangeEnd = 1138475, XrefRangeStart = 1138450, XrefRangeEnd = 1138474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddActionInternal(Delegate action, float delay, [Optional] Il2CppReferenceArray<Object> parameters)
		{
			if (parameters == null)
			{
				parameters = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedActionManager.NativeMethodInfoPtr_AddActionInternal_Private_Void_Delegate_Single_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000174 RID: 372 RVA: 0x0000AE18 File Offset: 0x00009018
		public unsafe static bool IsActive
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1138490, RefRangeEnd = 1138494, XrefRangeStart = 1138475, XrefRangeEnd = 1138490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedActionManager.NativeMethodInfoPtr_get_IsActive_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000AE48 File Offset: 0x00009048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138494, XrefRangeEnd = 1138514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Wait(float timeout = 0f, float timeAdvanceAmount = 0f)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeAdvanceAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedActionManager.NativeMethodInfoPtr_Wait_Public_Static_Boolean_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000AE94 File Offset: 0x00009094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138514, XrefRangeEnd = 1138516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedActionManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0000AEC8 File Offset: 0x000090C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1138545, RefRangeEnd = 1138547, XrefRangeStart = 1138516, XrefRangeEnd = 1138545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalLateUpdate(float t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedActionManager.NativeMethodInfoPtr_InternalLateUpdate_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000AF08 File Offset: 0x00009108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138547, XrefRangeEnd = 1138558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnApplicationQuit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedActionManager.NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000AF3C File Offset: 0x0000913C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138558, XrefRangeEnd = 1138599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DelayedActionManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelayedActionManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedActionManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002947 File Offset: 0x00000B47
		public static void AddAction(Delegate action, [Optional] float delay, params Object[] parameters)
		{
			DelayedActionManager.AddAction(action, delay, new Il2CppReferenceArray<Object>(parameters));
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002956 File Offset: 0x00000B56
		public void AddActionInternal(Delegate action, float delay, params Object[] parameters)
		{
			this.AddActionInternal(action, delay, new Il2CppReferenceArray<Object>(parameters));
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002966 File Offset: 0x00000B66
		public DelayedActionManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0000AF78 File Offset: 0x00009178
		// (set) Token: 0x0600017E RID: 382 RVA: 0x0000296F File Offset: 0x00000B6F
		public unsafe Il2CppReferenceArray<List<DelayedActionManager.DelegateInfo>> m_Actions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedActionManager.NativeFieldInfoPtr_m_Actions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<DelayedActionManager.DelegateInfo>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedActionManager.NativeFieldInfoPtr_m_Actions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0000AFA8 File Offset: 0x000091A8
		// (set) Token: 0x06000180 RID: 384 RVA: 0x0000298E File Offset: 0x00000B8E
		public unsafe LinkedList<DelayedActionManager.DelegateInfo> m_DelayedActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedActionManager.NativeFieldInfoPtr_m_DelayedActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<DelayedActionManager.DelegateInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedActionManager.NativeFieldInfoPtr_m_DelayedActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000181 RID: 385 RVA: 0x0000AFD8 File Offset: 0x000091D8
		// (set) Token: 0x06000182 RID: 386 RVA: 0x000029AD File Offset: 0x00000BAD
		public unsafe Stack<LinkedListNode<DelayedActionManager.DelegateInfo>> m_NodeCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedActionManager.NativeFieldInfoPtr_m_NodeCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<LinkedListNode<DelayedActionManager.DelegateInfo>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedActionManager.NativeFieldInfoPtr_m_NodeCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000183 RID: 387 RVA: 0x0000B008 File Offset: 0x00009208
		// (set) Token: 0x06000184 RID: 388 RVA: 0x000029CC File Offset: 0x00000BCC
		public unsafe int m_CollectionIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedActionManager.NativeFieldInfoPtr_m_CollectionIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedActionManager.NativeFieldInfoPtr_m_CollectionIndex)) = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000185 RID: 389 RVA: 0x0000B030 File Offset: 0x00009230
		// (set) Token: 0x06000186 RID: 390 RVA: 0x000029E7 File Offset: 0x00000BE7
		public unsafe bool m_DestroyOnCompletion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedActionManager.NativeFieldInfoPtr_m_DestroyOnCompletion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedActionManager.NativeFieldInfoPtr_m_DestroyOnCompletion)) = value;
			}
		}

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeFieldInfoPtr_m_Actions;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeFieldInfoPtr_m_DelayedActions;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeFieldInfoPtr_m_NodeCache;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeFieldInfoPtr_m_CollectionIndex;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeFieldInfoPtr_m_DestroyOnCompletion;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr_GetNode_Private_LinkedListNode_1_DelegateInfo_byref_DelegateInfo_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_0;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_DestroyWhenComplete_Private_Void_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_AddAction_Public_Static_Void_Delegate_Single_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr_AddActionInternal_Private_Void_Delegate_Single_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Public_Static_get_Boolean_0;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Public_Static_Boolean_Single_Single_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr_InternalLateUpdate_Private_Void_Single_0;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200007A RID: 122
		public sealed class DelegateInfo : ValueType
		{
			// Token: 0x06000625 RID: 1573 RVA: 0x0001D8BC File Offset: 0x0001BABC
			// Note: this type is marked as 'beforefieldinit'.
			static DelegateInfo()
			{
				Il2CppClassPointerStore<DelayedActionManager.DelegateInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DelayedActionManager>.NativeClassPtr, "DelegateInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelayedActionManager.DelegateInfo>.NativeClassPtr);
				DelayedActionManager.DelegateInfo.NativeFieldInfoPtr_s_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedActionManager.DelegateInfo>.NativeClassPtr, "s_Id");
				DelayedActionManager.DelegateInfo.NativeFieldInfoPtr_m_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedActionManager.DelegateInfo>.NativeClassPtr, "m_Id");
				DelayedActionManager.DelegateInfo.NativeFieldInfoPtr_m_Delegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedActionManager.DelegateInfo>.NativeClassPtr, "m_Delegate");
				DelayedActionManager.DelegateInfo.NativeFieldInfoPtr_m_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedActionManager.DelegateInfo>.NativeClassPtr, "m_Target");
				DelayedActionManager.DelegateInfo.NativeFieldInfoPtr__InvocationTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayedActionManager.DelegateInfo>.NativeClassPtr, "<InvocationTime>k__BackingField");
				DelayedActionManager.DelegateInfo.NativeMethodInfoPtr__ctor_Public_Void_Delegate_Single_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedActionManager.DelegateInfo>.NativeClassPtr, 100663585);
				DelayedActionManager.DelegateInfo.NativeMethodInfoPtr_get_InvocationTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedActionManager.DelegateInfo>.NativeClassPtr, 100663586);
				DelayedActionManager.DelegateInfo.NativeMethodInfoPtr_set_InvocationTime_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedActionManager.DelegateInfo>.NativeClassPtr, 100663587);
				DelayedActionManager.DelegateInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedActionManager.DelegateInfo>.NativeClassPtr, 100663588);
				DelayedActionManager.DelegateInfo.NativeMethodInfoPtr_Invoke_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedActionManager.DelegateInfo>.NativeClassPtr, 100663589);
			}

			// Token: 0x06000626 RID: 1574 RVA: 0x0001D9B0 File Offset: 0x0001BBB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138366, XrefRangeEnd = 1138370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DelegateInfo(Delegate d, float invocationTime, [Optional] Il2CppReferenceArray<Object> p)
			{
				if (p == null)
				{
					p = new Il2CppReferenceArray<Object>(0L);
				}
				this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelayedActionManager.DelegateInfo>.NativeClassPtr));
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invocationTime;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedActionManager.DelegateInfo.NativeMethodInfoPtr__ctor_Public_Void_Delegate_Single_Il2CppReferenceArray_1_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170001DF RID: 479
			// (get) Token: 0x06000627 RID: 1575 RVA: 0x0001DA30 File Offset: 0x0001BC30
			// (set) Token: 0x06000628 RID: 1576 RVA: 0x0001DA74 File Offset: 0x0001BC74
			public unsafe float InvocationTime
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedActionManager.DelegateInfo.NativeMethodInfoPtr_get_InvocationTime_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 644463, RefRangeEnd = 644464, XrefRangeStart = 644463, XrefRangeEnd = 644464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedActionManager.DelegateInfo.NativeMethodInfoPtr_set_InvocationTime_Private_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000629 RID: 1577 RVA: 0x0001DAB8 File Offset: 0x0001BCB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138370, XrefRangeEnd = 1138415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedActionManager.DelegateInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600062A RID: 1578 RVA: 0x0001DAF4 File Offset: 0x0001BCF4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1138429, RefRangeEnd = 1138430, XrefRangeStart = 1138415, XrefRangeEnd = 1138429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedActionManager.DelegateInfo.NativeMethodInfoPtr_Invoke_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600062B RID: 1579 RVA: 0x000044E1 File Offset: 0x000026E1
			public DelegateInfo(Delegate d, float invocationTime, params Object[] p)
				: this(d, invocationTime, new Il2CppReferenceArray<Object>(p))
			{
			}

			// Token: 0x0600062C RID: 1580 RVA: 0x000044F1 File Offset: 0x000026F1
			public DelegateInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600062D RID: 1581 RVA: 0x000044FA File Offset: 0x000026FA
			public DelegateInfo()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelayedActionManager.DelegateInfo>.NativeClassPtr))
			{
			}

			// Token: 0x170001DA RID: 474
			// (get) Token: 0x0600062E RID: 1582 RVA: 0x0001DB2C File Offset: 0x0001BD2C
			// (set) Token: 0x0600062F RID: 1583 RVA: 0x0000450C File Offset: 0x0000270C
			public unsafe static int s_Id
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(DelayedActionManager.DelegateInfo.NativeFieldInfoPtr_s_Id, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DelayedActionManager.DelegateInfo.NativeFieldInfoPtr_s_Id, (void*)(&value));
				}
			}

			// Token: 0x170001DB RID: 475
			// (get) Token: 0x06000630 RID: 1584 RVA: 0x0001DB48 File Offset: 0x0001BD48
			// (set) Token: 0x06000631 RID: 1585 RVA: 0x0000451A File Offset: 0x0000271A
			public unsafe int m_Id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedActionManager.DelegateInfo.NativeFieldInfoPtr_m_Id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedActionManager.DelegateInfo.NativeFieldInfoPtr_m_Id)) = value;
				}
			}

			// Token: 0x170001DC RID: 476
			// (get) Token: 0x06000632 RID: 1586 RVA: 0x0001DB70 File Offset: 0x0001BD70
			// (set) Token: 0x06000633 RID: 1587 RVA: 0x00004535 File Offset: 0x00002735
			public unsafe Delegate m_Delegate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedActionManager.DelegateInfo.NativeFieldInfoPtr_m_Delegate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedActionManager.DelegateInfo.NativeFieldInfoPtr_m_Delegate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001DD RID: 477
			// (get) Token: 0x06000634 RID: 1588 RVA: 0x0001DBA0 File Offset: 0x0001BDA0
			// (set) Token: 0x06000635 RID: 1589 RVA: 0x00004554 File Offset: 0x00002754
			public unsafe Il2CppReferenceArray<Object> m_Target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedActionManager.DelegateInfo.NativeFieldInfoPtr_m_Target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedActionManager.DelegateInfo.NativeFieldInfoPtr_m_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001DE RID: 478
			// (get) Token: 0x06000636 RID: 1590 RVA: 0x0001DBD0 File Offset: 0x0001BDD0
			// (set) Token: 0x06000637 RID: 1591 RVA: 0x00004573 File Offset: 0x00002773
			public unsafe float _InvocationTime_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedActionManager.DelegateInfo.NativeFieldInfoPtr__InvocationTime_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayedActionManager.DelegateInfo.NativeFieldInfoPtr__InvocationTime_k__BackingField)) = value;
				}
			}

			// Token: 0x04000462 RID: 1122
			private static readonly IntPtr NativeFieldInfoPtr_s_Id;

			// Token: 0x04000463 RID: 1123
			private static readonly IntPtr NativeFieldInfoPtr_m_Id;

			// Token: 0x04000464 RID: 1124
			private static readonly IntPtr NativeFieldInfoPtr_m_Delegate;

			// Token: 0x04000465 RID: 1125
			private static readonly IntPtr NativeFieldInfoPtr_m_Target;

			// Token: 0x04000466 RID: 1126
			private static readonly IntPtr NativeFieldInfoPtr__InvocationTime_k__BackingField;

			// Token: 0x04000467 RID: 1127
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Delegate_Single_Il2CppReferenceArray_1_Object_0;

			// Token: 0x04000468 RID: 1128
			private static readonly IntPtr NativeMethodInfoPtr_get_InvocationTime_Public_get_Single_0;

			// Token: 0x04000469 RID: 1129
			private static readonly IntPtr NativeMethodInfoPtr_set_InvocationTime_Private_set_Void_Single_0;

			// Token: 0x0400046A RID: 1130
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x0400046B RID: 1131
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_0;
		}
	}
}
