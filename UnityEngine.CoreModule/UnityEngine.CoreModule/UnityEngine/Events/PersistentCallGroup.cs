using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Events
{
	// Token: 0x020001AC RID: 428
	[Serializable]
	public class PersistentCallGroup : Object
	{
		// Token: 0x06001F7D RID: 8061 RVA: 0x0008CB38 File Offset: 0x0008AD38
		// Note: this type is marked as 'beforefieldinit'.
		static PersistentCallGroup()
		{
			Il2CppClassPointerStore<PersistentCallGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "PersistentCallGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistentCallGroup>.NativeClassPtr);
			PersistentCallGroup.NativeFieldInfoPtr_m_Calls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentCallGroup>.NativeClassPtr, "m_Calls");
			PersistentCallGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCallGroup>.NativeClassPtr, 100667610);
			PersistentCallGroup.NativeMethodInfoPtr_Initialize_Public_Void_InvokableCallList_UnityEventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCallGroup>.NativeClassPtr, 100667611);
		}

		// Token: 0x06001F7E RID: 8062 RVA: 0x0008CBA4 File Offset: 0x0008ADA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 678587, XrefRangeEnd = 678595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PersistentCallGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistentCallGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCallGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F7F RID: 8063 RVA: 0x0008CBE0 File Offset: 0x0008ADE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 678614, RefRangeEnd = 678617, XrefRangeStart = 678595, XrefRangeEnd = 678614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(InvokableCallList invokableList, UnityEventBase unityEventBase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokableList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(unityEventBase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCallGroup.NativeMethodInfoPtr_Initialize_Public_Void_InvokableCallList_UnityEventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x0000BF51 File Offset: 0x0000A151
		public PersistentCallGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001F81 RID: 8065 RVA: 0x0008CC34 File Offset: 0x0008AE34
		// (set) Token: 0x06001F82 RID: 8066 RVA: 0x0000BF5A File Offset: 0x0000A15A
		public unsafe List<PersistentCall> m_Calls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCallGroup.NativeFieldInfoPtr_m_Calls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PersistentCall>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCallGroup.NativeFieldInfoPtr_m_Calls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001F83 RID: 8067 RVA: 0x0008CC64 File Offset: 0x0008AE64
		public int Count
		{
			get
			{
				return this.m_Calls.Count;
			}
		}

		// Token: 0x06001F84 RID: 8068 RVA: 0x0008CC84 File Offset: 0x0008AE84
		public PersistentCall GetListener(int index)
		{
			return this.m_Calls[index];
		}

		// Token: 0x06001F85 RID: 8069 RVA: 0x0008CCA4 File Offset: 0x0008AEA4
		public IEnumerable<PersistentCall> GetListeners()
		{
			return this.m_Calls;
		}

		// Token: 0x06001F86 RID: 8070 RVA: 0x0000BF79 File Offset: 0x0000A179
		public void AddListener()
		{
			this.m_Calls.Add(new PersistentCall());
		}

		// Token: 0x06001F87 RID: 8071 RVA: 0x0000BF8D File Offset: 0x0000A18D
		public void AddListener(PersistentCall call)
		{
			this.m_Calls.Add(call);
		}

		// Token: 0x06001F88 RID: 8072 RVA: 0x0000BF9D File Offset: 0x0000A19D
		public void RemoveListener(int index)
		{
			this.m_Calls.RemoveAt(index);
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x0000BFAD File Offset: 0x0000A1AD
		public void Clear()
		{
			this.m_Calls.Clear();
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x0008CCBC File Offset: 0x0008AEBC
		public void RegisterEventPersistentListener(int index, Object targetObj, Type targetObjType, string methodName)
		{
			PersistentCall listener = this.GetListener(index);
			listener.RegisterPersistentListener(targetObj, targetObjType, methodName);
			listener.mode = PersistentListenerMode.EventDefined;
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x0008CCE8 File Offset: 0x0008AEE8
		public void RegisterVoidPersistentListener(int index, Object targetObj, Type targetObjType, string methodName)
		{
			PersistentCall listener = this.GetListener(index);
			listener.RegisterPersistentListener(targetObj, targetObjType, methodName);
			listener.mode = PersistentListenerMode.Void;
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x0008CD14 File Offset: 0x0008AF14
		public void RegisterObjectPersistentListener(int index, Object targetObj, Type targetObjType, Object argument, string methodName)
		{
			PersistentCall listener = this.GetListener(index);
			listener.RegisterPersistentListener(targetObj, targetObjType, methodName);
			listener.mode = PersistentListenerMode.Object;
			listener.arguments.unityObjectArgument = argument;
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x0008CD4C File Offset: 0x0008AF4C
		public void RegisterIntPersistentListener(int index, Object targetObj, Type targetObjType, int argument, string methodName)
		{
			PersistentCall listener = this.GetListener(index);
			listener.RegisterPersistentListener(targetObj, targetObjType, methodName);
			listener.mode = PersistentListenerMode.Int;
			listener.arguments.intArgument = argument;
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x0008CD84 File Offset: 0x0008AF84
		public void RegisterFloatPersistentListener(int index, Object targetObj, Type targetObjType, float argument, string methodName)
		{
			PersistentCall listener = this.GetListener(index);
			listener.RegisterPersistentListener(targetObj, targetObjType, methodName);
			listener.mode = PersistentListenerMode.Float;
			listener.arguments.floatArgument = argument;
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x0008CDBC File Offset: 0x0008AFBC
		public void RegisterStringPersistentListener(int index, Object targetObj, Type targetObjType, string argument, string methodName)
		{
			PersistentCall listener = this.GetListener(index);
			listener.RegisterPersistentListener(targetObj, targetObjType, methodName);
			listener.mode = PersistentListenerMode.String;
			listener.arguments.stringArgument = argument;
		}

		// Token: 0x06001F90 RID: 8080 RVA: 0x0008CDF4 File Offset: 0x0008AFF4
		public void RegisterBoolPersistentListener(int index, Object targetObj, Type targetObjType, bool argument, string methodName)
		{
			PersistentCall listener = this.GetListener(index);
			listener.RegisterPersistentListener(targetObj, targetObjType, methodName);
			listener.mode = PersistentListenerMode.Bool;
			listener.arguments.boolArgument = argument;
		}

		// Token: 0x06001F91 RID: 8081 RVA: 0x0008CE2C File Offset: 0x0008B02C
		public void UnregisterPersistentListener(int index)
		{
			PersistentCall listener = this.GetListener(index);
			listener.UnregisterPersistentListener();
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x0008CE4C File Offset: 0x0008B04C
		public void RemoveListeners(Object target, string methodName)
		{
			List<PersistentCall> list = new List<PersistentCall>();
			for (int i = 0; i < this.m_Calls.Count; i++)
			{
				bool flag = this.m_Calls[i].target == target && this.m_Calls[i].methodName == methodName;
				if (flag)
				{
					list.Add(this.m_Calls[i]);
				}
			}
			this.m_Calls.RemoveAll(new Predicate<PersistentCall>(list.Contains));
		}

		// Token: 0x04001B6B RID: 7019
		private static readonly IntPtr NativeFieldInfoPtr_m_Calls;

		// Token: 0x04001B6C RID: 7020
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001B6D RID: 7021
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_InvokableCallList_UnityEventBase_0;
	}
}
