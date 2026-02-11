using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;

namespace UnityEngine
{
	// Token: 0x02000107 RID: 263
	public sealed class ObjectDispatcher : Object
	{
		// Token: 0x06001602 RID: 5634 RVA: 0x0006B4A8 File Offset: 0x000696A8
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectDispatcher()
		{
			Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ObjectDispatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr);
			ObjectDispatcher.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, "m_Ptr");
			ObjectDispatcher.NativeFieldInfoPtr_s_TypeDispatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, "s_TypeDispatch");
			ObjectDispatcher.NativeFieldInfoPtr_s_TransformDispatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, "s_TransformDispatch");
			ObjectDispatcher.CreateDispatchSystemHandleDelegateField = IL2CPP.ResolveICall<ObjectDispatcher.CreateDispatchSystemHandleDelegate>("UnityEngine.ObjectDispatcher::CreateDispatchSystemHandle");
			ObjectDispatcher.DestroyDispatchSystemHandleDelegateField = IL2CPP.ResolveICall<ObjectDispatcher.DestroyDispatchSystemHandleDelegate>("UnityEngine.ObjectDispatcher::DestroyDispatchSystemHandle");
			ObjectDispatcher.GetMaxDispatchHistoryFramesCountDelegateField = IL2CPP.ResolveICall<ObjectDispatcher.GetMaxDispatchHistoryFramesCountDelegate>("UnityEngine.ObjectDispatcher::GetMaxDispatchHistoryFramesCount");
			ObjectDispatcher.SetMaxDispatchHistoryFramesCountDelegateField = IL2CPP.ResolveICall<ObjectDispatcher.SetMaxDispatchHistoryFramesCountDelegate>("UnityEngine.ObjectDispatcher::SetMaxDispatchHistoryFramesCount");
			ObjectDispatcher.EnableTypeTrackingDelegateField = IL2CPP.ResolveICall<ObjectDispatcher.EnableTypeTrackingDelegate>("UnityEngine.ObjectDispatcher::EnableTypeTracking");
			ObjectDispatcher.DisableTypeTrackingDelegateField = IL2CPP.ResolveICall<ObjectDispatcher.DisableTypeTrackingDelegate>("UnityEngine.ObjectDispatcher::DisableTypeTracking");
			ObjectDispatcher.EnableTransformTrackingDelegateField = IL2CPP.ResolveICall<ObjectDispatcher.EnableTransformTrackingDelegate>("UnityEngine.ObjectDispatcher::EnableTransformTracking");
			ObjectDispatcher.DisableTransformTrackingDelegateField = IL2CPP.ResolveICall<ObjectDispatcher.DisableTransformTrackingDelegate>("UnityEngine.ObjectDispatcher::DisableTransformTracking");
			ObjectDispatcher.DispatchTypeChangesAndClearDelegateField = IL2CPP.ResolveICall<ObjectDispatcher.DispatchTypeChangesAndClearDelegate>("UnityEngine.ObjectDispatcher::DispatchTypeChangesAndClear");
			ObjectDispatcher.DispatchTransformDataChangesAndClearDelegateField = IL2CPP.ResolveICall<ObjectDispatcher.DispatchTransformDataChangesAndClearDelegate>("UnityEngine.ObjectDispatcher::DispatchTransformDataChangesAndClear");
			ObjectDispatcher.DispatchTransformChangesAndClearDelegateField = IL2CPP.ResolveICall<ObjectDispatcher.DispatchTransformChangesAndClearDelegate>("UnityEngine.ObjectDispatcher::DispatchTransformChangesAndClear");
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x00008995 File Offset: 0x00006B95
		public ObjectDispatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06001604 RID: 5636 RVA: 0x0006B5BC File Offset: 0x000697BC
		// (set) Token: 0x06001605 RID: 5637 RVA: 0x0000899E File Offset: 0x00006B9E
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectDispatcher.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectDispatcher.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06001606 RID: 5638 RVA: 0x0006B5E4 File Offset: 0x000697E4
		// (set) Token: 0x06001607 RID: 5639 RVA: 0x000089B9 File Offset: 0x00006BB9
		public unsafe static Action<Il2CppReferenceArray<Object>, IntPtr, IntPtr, int, int, Action<TypeDispatchData>> s_TypeDispatch
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ObjectDispatcher.NativeFieldInfoPtr_s_TypeDispatch, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Il2CppReferenceArray<Object>, IntPtr, IntPtr, int, int, Action<TypeDispatchData>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObjectDispatcher.NativeFieldInfoPtr_s_TypeDispatch, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06001608 RID: 5640 RVA: 0x0006B60C File Offset: 0x0006980C
		// (set) Token: 0x06001609 RID: 5641 RVA: 0x000089CB File Offset: 0x00006BCB
		public unsafe static Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, Action<TransformDispatchData>> s_TransformDispatch
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ObjectDispatcher.NativeFieldInfoPtr_s_TransformDispatch, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, Action<TransformDispatchData>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObjectDispatcher.NativeFieldInfoPtr_s_TransformDispatch, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x0600160A RID: 5642 RVA: 0x0006B634 File Offset: 0x00069834
		public bool valid
		{
			get
			{
				return this.m_Ptr != IntPtr.Zero;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x0600160B RID: 5643 RVA: 0x0006B658 File Offset: 0x00069858
		// (set) Token: 0x0600160C RID: 5644 RVA: 0x000089DD File Offset: 0x00006BDD
		public int maxDispatchHistoryFramesCount
		{
			get
			{
				this.ValidateSystemHandleAndThrow();
				return ObjectDispatcher.GetMaxDispatchHistoryFramesCount(this.m_Ptr);
			}
			set
			{
				this.ValidateSystemHandleAndThrow();
				ObjectDispatcher.SetMaxDispatchHistoryFramesCount(this.m_Ptr, value);
			}
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x0006B67C File Offset: 0x0006987C
		public ~ObjectDispatcher()
		{
			this.Dispose(false);
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x000089F4 File Offset: 0x00006BF4
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x0006B6B0 File Offset: 0x000698B0
		public void Dispose(bool disposing)
		{
			bool flag = this.m_Ptr != IntPtr.Zero;
			if (flag)
			{
				ObjectDispatcher.DestroyDispatchSystemHandle(this.m_Ptr);
				this.m_Ptr = IntPtr.Zero;
			}
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x0006B6EC File Offset: 0x000698EC
		public void ValidateSystemHandleAndThrow()
		{
			bool flag = !this.valid;
			if (flag)
			{
				throw new Exception("The ObjectDispatcher is invalid or has been disposed.");
			}
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x0006B714 File Offset: 0x00069914
		public void ValidateTypeAndThrow(Type type)
		{
			bool flag = !type.IsSubclassOf(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()));
			if (flag)
			{
				throw new Exception("Only types inherited from UnityEngine.Object are supported.");
			}
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x0006B744 File Offset: 0x00069944
		public void ValidateComponentTypeAndThrow(Type type)
		{
			bool flag = !type.IsSubclassOf(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Component>()));
			if (flag)
			{
				throw new Exception("Only types inherited from UnityEngine.Component are supported.");
			}
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x00008A06 File Offset: 0x00006C06
		public void DispatchTypeChangesAndClear(Type type, Action<TypeDispatchData> callback, [Optional] bool sortByInstanceID, [Optional] bool noScriptingArray)
		{
			this.ValidateSystemHandleAndThrow();
			this.ValidateTypeAndThrow(type);
			ObjectDispatcher.DispatchTypeChangesAndClear(this.m_Ptr, type, ObjectDispatcher.s_TypeDispatch, sortByInstanceID, noScriptingArray, callback);
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x00008A2E File Offset: 0x00006C2E
		public void DispatchTransformChangesAndClear(Type type, ObjectDispatcher.TransformTrackingType trackingType, Action<Il2CppReferenceArray<Component>> callback, [Optional] bool sortByInstanceID)
		{
			this.ValidateSystemHandleAndThrow();
			this.ValidateComponentTypeAndThrow(type);
			ObjectDispatcher.DispatchTransformChangesAndClear(this.m_Ptr, type, trackingType, callback, sortByInstanceID);
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x00008A51 File Offset: 0x00006C51
		public void DispatchTransformChangesAndClear(Type type, ObjectDispatcher.TransformTrackingType trackingType, Action<TransformDispatchData> callback)
		{
			this.ValidateSystemHandleAndThrow();
			this.ValidateComponentTypeAndThrow(type);
			ObjectDispatcher.DispatchTransformDataChangesAndClear(this.m_Ptr, type, trackingType, ObjectDispatcher.s_TransformDispatch, callback);
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x00008A77 File Offset: 0x00006C77
		public void ClearTypeChanges(Type type)
		{
			this.ValidateSystemHandleAndThrow();
			this.ValidateTypeAndThrow(type);
			ObjectDispatcher.DispatchTypeChangesAndClear(this.m_Ptr, type, null, false, false, null);
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x00008A9A File Offset: 0x00006C9A
		public TypeDispatchData GetTypeChangesAndClear(Type type, Unity.Collections.Allocator allocator, [Optional] bool sortByInstanceID, [Optional] bool noScriptingArray)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x00008AA7 File Offset: 0x00006CA7
		public void GetTypeChangesAndClear(Type type, List<Object> changed, out Unity.Collections.NativeArray<int> changedID, out Unity.Collections.NativeArray<int> destroyedID, Unity.Collections.Allocator allocator, [Optional] bool sortByInstanceID)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x00008AB4 File Offset: 0x00006CB4
		public Il2CppReferenceArray<Component> GetTransformChangesAndClear(Type type, ObjectDispatcher.TransformTrackingType trackingType, [Optional] bool sortByInstanceID)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x00008AC1 File Offset: 0x00006CC1
		public TransformDispatchData GetTransformChangesAndClear(Type type, ObjectDispatcher.TransformTrackingType trackingType, Unity.Collections.Allocator allocator)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x00008ACE File Offset: 0x00006CCE
		public void EnableTypeTracking(ObjectDispatcher.TypeTrackingFlags typeTrackingMask, Il2CppReferenceArray<Type> types)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x00008ADB File Offset: 0x00006CDB
		public void EnableTypeTracking(ObjectDispatcher.TypeTrackingFlags typeTrackingMask, params Type[] types)
		{
			this.EnableTypeTracking(typeTrackingMask, new Il2CppReferenceArray<Type>(types));
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x00008AEA File Offset: 0x00006CEA
		public void EnableTypeTracking(Il2CppReferenceArray<Type> types)
		{
			this.EnableTypeTracking(ObjectDispatcher.TypeTrackingFlags.Default, types);
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x00008AF6 File Offset: 0x00006CF6
		public void EnableTypeTracking(params Type[] types)
		{
			this.EnableTypeTracking(new Il2CppReferenceArray<Type>(types));
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x00008B04 File Offset: 0x00006D04
		public void EnableTypeTrackingIncludingAssets(Il2CppReferenceArray<Type> types)
		{
			this.EnableTypeTracking(ObjectDispatcher.TypeTrackingFlags.Default, types);
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x00008B10 File Offset: 0x00006D10
		public void EnableTypeTrackingIncludingAssets(params Type[] types)
		{
			this.EnableTypeTrackingIncludingAssets(new Il2CppReferenceArray<Type>(types));
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x00008B1E File Offset: 0x00006D1E
		public void DisableTypeTracking(Il2CppReferenceArray<Type> types)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x00008B2B File Offset: 0x00006D2B
		public void DisableTypeTracking(params Type[] types)
		{
			this.DisableTypeTracking(new Il2CppReferenceArray<Type>(types));
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x00008B39 File Offset: 0x00006D39
		public void EnableTransformTracking(ObjectDispatcher.TransformTrackingType trackingType, Il2CppReferenceArray<Type> types)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x00008B46 File Offset: 0x00006D46
		public void EnableTransformTracking(ObjectDispatcher.TransformTrackingType trackingType, params Type[] types)
		{
			this.EnableTransformTracking(trackingType, new Il2CppReferenceArray<Type>(types));
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x00008B55 File Offset: 0x00006D55
		public void DisableTransformTracking(ObjectDispatcher.TransformTrackingType trackingType, Il2CppReferenceArray<Type> types)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x00008B62 File Offset: 0x00006D62
		public void DisableTransformTracking(ObjectDispatcher.TransformTrackingType trackingType, params Type[] types)
		{
			this.DisableTransformTracking(trackingType, new Il2CppReferenceArray<Type>(types));
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x00008B71 File Offset: 0x00006D71
		public void DispatchTypeChangesAndClear<T>(Action<TypeDispatchData> callback, [Optional] bool sortByInstanceID, [Optional] bool noScriptingArray) where T : Object
		{
			this.DispatchTypeChangesAndClear(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), callback, sortByInstanceID, noScriptingArray);
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x00008B88 File Offset: 0x00006D88
		public void DispatchTransformChangesAndClear<T>(ObjectDispatcher.TransformTrackingType trackingType, Action<Il2CppReferenceArray<Component>> callback, [Optional] bool sortByInstanceID) where T : Object
		{
			this.DispatchTransformChangesAndClear(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), trackingType, callback, sortByInstanceID);
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x00008B9F File Offset: 0x00006D9F
		public void DispatchTransformChangesAndClear<T>(ObjectDispatcher.TransformTrackingType trackingType, Action<TransformDispatchData> callback) where T : Object
		{
			this.DispatchTransformChangesAndClear(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), trackingType, callback);
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x00008BB5 File Offset: 0x00006DB5
		public void ClearTypeChanges<T>() where T : Object
		{
			this.ClearTypeChanges(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x0006B774 File Offset: 0x00069974
		public TypeDispatchData GetTypeChangesAndClear<T>(Unity.Collections.Allocator allocator, [Optional] bool sortByInstanceID, [Optional] bool noScriptingArray) where T : Object
		{
			return this.GetTypeChangesAndClear(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), allocator, sortByInstanceID, noScriptingArray);
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x00008BC9 File Offset: 0x00006DC9
		public void GetTypeChangesAndClear<T>(List<Object> changed, out Unity.Collections.NativeArray<int> changedID, out Unity.Collections.NativeArray<int> destroyedID, Unity.Collections.Allocator allocator, [Optional] bool sortByInstanceID) where T : Object
		{
			this.GetTypeChangesAndClear(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), changed, out changedID, out destroyedID, allocator, sortByInstanceID);
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x0006B79C File Offset: 0x0006999C
		public Il2CppReferenceArray<Component> GetTransformChangesAndClear<T>(ObjectDispatcher.TransformTrackingType trackingType, [Optional] bool sortByInstanceID) where T : Object
		{
			return this.GetTransformChangesAndClear(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), trackingType, sortByInstanceID);
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x0006B7C0 File Offset: 0x000699C0
		public TransformDispatchData GetTransformChangesAndClear<T>(ObjectDispatcher.TransformTrackingType trackingType, Unity.Collections.Allocator allocator) where T : Object
		{
			return this.GetTransformChangesAndClear(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), trackingType, allocator);
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x00008BE4 File Offset: 0x00006DE4
		public void EnableTypeTracking<T>([Optional] ObjectDispatcher.TypeTrackingFlags typeTrackingMask) where T : Object
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x00008BF1 File Offset: 0x00006DF1
		public void DisableTypeTracking<T>() where T : Object
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x00008BFE File Offset: 0x00006DFE
		public void EnableTransformTracking<T>(ObjectDispatcher.TransformTrackingType trackingType) where T : Object
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x00008C0B File Offset: 0x00006E0B
		public void DisableTransformTracking<T>(ObjectDispatcher.TransformTrackingType trackingType) where T : Object
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x00008C18 File Offset: 0x00006E18
		public static IntPtr CreateDispatchSystemHandle()
		{
			return ObjectDispatcher.CreateDispatchSystemHandleDelegateField();
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x00008C24 File Offset: 0x00006E24
		public static void DestroyDispatchSystemHandle(IntPtr ptr)
		{
			ObjectDispatcher.DestroyDispatchSystemHandleDelegateField(ptr);
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x00008C31 File Offset: 0x00006E31
		public static int GetMaxDispatchHistoryFramesCount(IntPtr ptr)
		{
			return ObjectDispatcher.GetMaxDispatchHistoryFramesCountDelegateField(ptr);
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x00008C3E File Offset: 0x00006E3E
		public static void SetMaxDispatchHistoryFramesCount(IntPtr ptr, int count)
		{
			ObjectDispatcher.SetMaxDispatchHistoryFramesCountDelegateField(ptr, count);
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x00008C4C File Offset: 0x00006E4C
		public static void EnableTypeTracking(IntPtr ptr, Type type, ObjectDispatcher.TypeTrackingFlags typeTrackingMask)
		{
			ObjectDispatcher.EnableTypeTrackingDelegateField(ptr, IL2CPP.Il2CppObjectBaseToPtr(type), typeTrackingMask);
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x00008C60 File Offset: 0x00006E60
		public static void DisableTypeTracking(IntPtr ptr, Type type)
		{
			ObjectDispatcher.DisableTypeTrackingDelegateField(ptr, IL2CPP.Il2CppObjectBaseToPtr(type));
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x00008C73 File Offset: 0x00006E73
		public static void EnableTransformTracking(IntPtr ptr, Type type, ObjectDispatcher.TransformTrackingType trackingType)
		{
			ObjectDispatcher.EnableTransformTrackingDelegateField(ptr, IL2CPP.Il2CppObjectBaseToPtr(type), trackingType);
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x00008C87 File Offset: 0x00006E87
		public static void DisableTransformTracking(IntPtr ptr, Type type, ObjectDispatcher.TransformTrackingType trackingType)
		{
			ObjectDispatcher.DisableTransformTrackingDelegateField(ptr, IL2CPP.Il2CppObjectBaseToPtr(type), trackingType);
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x00008C9B File Offset: 0x00006E9B
		public static void DispatchTypeChangesAndClear(IntPtr ptr, Type type, Action<Il2CppReferenceArray<Object>, IntPtr, IntPtr, int, int, Action<TypeDispatchData>> callback, bool sortByInstanceID, bool noScriptingArray, Action<TypeDispatchData> param)
		{
			ObjectDispatcher.DispatchTypeChangesAndClearDelegateField(ptr, IL2CPP.Il2CppObjectBaseToPtr(type), IL2CPP.Il2CppObjectBaseToPtr(callback), sortByInstanceID, noScriptingArray, IL2CPP.Il2CppObjectBaseToPtr(param));
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x00008CBE File Offset: 0x00006EBE
		public static void DispatchTransformDataChangesAndClear(IntPtr ptr, Type type, ObjectDispatcher.TransformTrackingType trackingType, Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, Action<TransformDispatchData>> callback, Action<TransformDispatchData> param)
		{
			ObjectDispatcher.DispatchTransformDataChangesAndClearDelegateField(ptr, IL2CPP.Il2CppObjectBaseToPtr(type), trackingType, IL2CPP.Il2CppObjectBaseToPtr(callback), IL2CPP.Il2CppObjectBaseToPtr(param));
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x00008CDF File Offset: 0x00006EDF
		public static void DispatchTransformChangesAndClear(IntPtr ptr, Type type, ObjectDispatcher.TransformTrackingType trackingType, Action<Il2CppReferenceArray<Component>> callback, bool sortByInstanceID)
		{
			ObjectDispatcher.DispatchTransformChangesAndClearDelegateField(ptr, IL2CPP.Il2CppObjectBaseToPtr(type), trackingType, IL2CPP.Il2CppObjectBaseToPtr(callback), sortByInstanceID);
		}

		// Token: 0x04001472 RID: 5234
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04001473 RID: 5235
		private static readonly IntPtr NativeFieldInfoPtr_s_TypeDispatch;

		// Token: 0x04001474 RID: 5236
		private static readonly IntPtr NativeFieldInfoPtr_s_TransformDispatch;

		// Token: 0x04001475 RID: 5237
		private static readonly ObjectDispatcher.CreateDispatchSystemHandleDelegate CreateDispatchSystemHandleDelegateField;

		// Token: 0x04001476 RID: 5238
		private static readonly ObjectDispatcher.DestroyDispatchSystemHandleDelegate DestroyDispatchSystemHandleDelegateField;

		// Token: 0x04001477 RID: 5239
		private static readonly ObjectDispatcher.GetMaxDispatchHistoryFramesCountDelegate GetMaxDispatchHistoryFramesCountDelegateField;

		// Token: 0x04001478 RID: 5240
		private static readonly ObjectDispatcher.SetMaxDispatchHistoryFramesCountDelegate SetMaxDispatchHistoryFramesCountDelegateField;

		// Token: 0x04001479 RID: 5241
		private static readonly ObjectDispatcher.EnableTypeTrackingDelegate EnableTypeTrackingDelegateField;

		// Token: 0x0400147A RID: 5242
		private static readonly ObjectDispatcher.DisableTypeTrackingDelegate DisableTypeTrackingDelegateField;

		// Token: 0x0400147B RID: 5243
		private static readonly ObjectDispatcher.EnableTransformTrackingDelegate EnableTransformTrackingDelegateField;

		// Token: 0x0400147C RID: 5244
		private static readonly ObjectDispatcher.DisableTransformTrackingDelegate DisableTransformTrackingDelegateField;

		// Token: 0x0400147D RID: 5245
		private static readonly ObjectDispatcher.DispatchTypeChangesAndClearDelegate DispatchTypeChangesAndClearDelegateField;

		// Token: 0x0400147E RID: 5246
		private static readonly ObjectDispatcher.DispatchTransformDataChangesAndClearDelegate DispatchTransformDataChangesAndClearDelegateField;

		// Token: 0x0400147F RID: 5247
		private static readonly ObjectDispatcher.DispatchTransformChangesAndClearDelegate DispatchTransformChangesAndClearDelegateField;

		// Token: 0x020006F8 RID: 1784
		[ObfuscatedName("UnityEngine.ObjectDispatcher+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060036CE RID: 14030 RVA: 0x000BA604 File Offset: 0x000B8804
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ObjectDispatcher.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectDispatcher.__c>.NativeClassPtr);
				ObjectDispatcher.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectDispatcher.__c>.NativeClassPtr, "<>9");
				ObjectDispatcher.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher.__c>.NativeClassPtr, 100666374);
				ObjectDispatcher.__c.NativeMethodInfoPtr___cctor_b__54_0_Internal_Void_Il2CppReferenceArray_1_Object_IntPtr_IntPtr_Int32_Int32_Action_1_TypeDispatchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher.__c>.NativeClassPtr, 100666375);
				ObjectDispatcher.__c.NativeMethodInfoPtr___cctor_b__54_1_Internal_Void_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_Int32_Action_1_TransformDispatchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher.__c>.NativeClassPtr, 100666376);
			}

			// Token: 0x060036CF RID: 14031 RVA: 0x000BA680 File Offset: 0x000B8880
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectDispatcher.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectDispatcher.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060036D0 RID: 14032 RVA: 0x000BA6BC File Offset: 0x000B88BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659929, XrefRangeEnd = 659935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__54_0(Il2CppReferenceArray<Object> changed, IntPtr changedID, IntPtr destroyedID, int changedCount, int destroyedCount, Action<TypeDispatchData> callback)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(changed);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref changedID;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destroyedID;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref changedCount;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destroyedCount;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectDispatcher.__c.NativeMethodInfoPtr___cctor_b__54_0_Internal_Void_Il2CppReferenceArray_1_Object_IntPtr_IntPtr_Int32_Int32_Action_1_TypeDispatchData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060036D1 RID: 14033 RVA: 0x000BA74C File Offset: 0x000B894C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659935, XrefRangeEnd = 659956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__54_1(IntPtr transformed, IntPtr parents, IntPtr localToWorldMatrices, IntPtr positions, IntPtr rotations, IntPtr scales, int count, Action<TransformDispatchData> callback)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref transformed;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parents;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref localToWorldMatrices;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref positions;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotations;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scales;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectDispatcher.__c.NativeMethodInfoPtr___cctor_b__54_1_Internal_Void_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_Int32_Action_1_TransformDispatchData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060036D2 RID: 14034 RVA: 0x00013DE7 File Offset: 0x00011FE7
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A19 RID: 2585
			// (get) Token: 0x060036D3 RID: 14035 RVA: 0x000BA7F4 File Offset: 0x000B89F4
			// (set) Token: 0x060036D4 RID: 14036 RVA: 0x00013DF0 File Offset: 0x00011FF0
			public unsafe static ObjectDispatcher.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ObjectDispatcher.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectDispatcher.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ObjectDispatcher.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C11 RID: 11281
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002C12 RID: 11282
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002C13 RID: 11283
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__54_0_Internal_Void_Il2CppReferenceArray_1_Object_IntPtr_IntPtr_Int32_Int32_Action_1_TypeDispatchData_0;

			// Token: 0x04002C14 RID: 11284
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__54_1_Internal_Void_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_Int32_Action_1_TransformDispatchData_0;
		}

		// Token: 0x020006F9 RID: 1785
		public enum TransformTrackingType
		{
			// Token: 0x04002C16 RID: 11286
			GlobalTRS,
			// Token: 0x04002C17 RID: 11287
			LocalTRS,
			// Token: 0x04002C18 RID: 11288
			Hierarchy
		}

		// Token: 0x020006FA RID: 1786
		public enum TypeTrackingFlags
		{
			// Token: 0x04002C1A RID: 11290
			SceneObjects = 1,
			// Token: 0x04002C1B RID: 11291
			Assets,
			// Token: 0x04002C1C RID: 11292
			EditorOnlyObjects = 4,
			// Token: 0x04002C1D RID: 11293
			Default = 3,
			// Token: 0x04002C1E RID: 11294
			All = 7
		}

		// Token: 0x020006FB RID: 1787
		[Serializable]
		public sealed class <>c
		{
		}

		// Token: 0x020006FC RID: 1788
		public sealed class <>c__DisplayClass21_0
		{
		}

		// Token: 0x020006FD RID: 1789
		public sealed class <>c__DisplayClass22_0
		{
		}

		// Token: 0x020006FE RID: 1790
		public sealed class <>c__DisplayClass23_0
		{
		}

		// Token: 0x020006FF RID: 1791
		public sealed class <>c__DisplayClass24_0
		{
		}

		// Token: 0x02000700 RID: 1792
		// (Invoke) Token: 0x060036D6 RID: 14038
		private delegate IntPtr CreateDispatchSystemHandleDelegate();

		// Token: 0x02000701 RID: 1793
		// (Invoke) Token: 0x060036D8 RID: 14040
		private delegate void DestroyDispatchSystemHandleDelegate(IntPtr ptr);

		// Token: 0x02000702 RID: 1794
		// (Invoke) Token: 0x060036DA RID: 14042
		private delegate int GetMaxDispatchHistoryFramesCountDelegate(IntPtr ptr);

		// Token: 0x02000703 RID: 1795
		// (Invoke) Token: 0x060036DC RID: 14044
		private delegate void SetMaxDispatchHistoryFramesCountDelegate(IntPtr ptr, int count);

		// Token: 0x02000704 RID: 1796
		// (Invoke) Token: 0x060036DE RID: 14046
		private delegate void EnableTypeTrackingDelegate(IntPtr ptr, IntPtr type, ObjectDispatcher.TypeTrackingFlags typeTrackingMask);

		// Token: 0x02000705 RID: 1797
		// (Invoke) Token: 0x060036E0 RID: 14048
		private delegate void DisableTypeTrackingDelegate(IntPtr ptr, IntPtr type);

		// Token: 0x02000706 RID: 1798
		// (Invoke) Token: 0x060036E2 RID: 14050
		private delegate void EnableTransformTrackingDelegate(IntPtr ptr, IntPtr type, ObjectDispatcher.TransformTrackingType trackingType);

		// Token: 0x02000707 RID: 1799
		// (Invoke) Token: 0x060036E4 RID: 14052
		private delegate void DisableTransformTrackingDelegate(IntPtr ptr, IntPtr type, ObjectDispatcher.TransformTrackingType trackingType);

		// Token: 0x02000708 RID: 1800
		// (Invoke) Token: 0x060036E6 RID: 14054
		private delegate void DispatchTypeChangesAndClearDelegate(IntPtr ptr, IntPtr type, IntPtr callback, bool sortByInstanceID, bool noScriptingArray, IntPtr param);

		// Token: 0x02000709 RID: 1801
		// (Invoke) Token: 0x060036E8 RID: 14056
		private delegate void DispatchTransformDataChangesAndClearDelegate(IntPtr ptr, IntPtr type, ObjectDispatcher.TransformTrackingType trackingType, IntPtr callback, IntPtr param);

		// Token: 0x0200070A RID: 1802
		// (Invoke) Token: 0x060036EA RID: 14058
		private delegate void DispatchTransformChangesAndClearDelegate(IntPtr ptr, IntPtr type, ObjectDispatcher.TransformTrackingType trackingType, IntPtr callback, bool sortByInstanceID);
	}
}
