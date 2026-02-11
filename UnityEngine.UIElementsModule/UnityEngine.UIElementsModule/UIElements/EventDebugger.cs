using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;

namespace UnityEngine.UIElements
{
	// Token: 0x020000DD RID: 221
	public class EventDebugger : Object
	{
		// Token: 0x060012E8 RID: 4840 RVA: 0x00009476 File Offset: 0x00007676
		// Note: this type is marked as 'beforefieldinit'.
		static EventDebugger()
		{
			Il2CppClassPointerStore<EventDebugger>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventDebugger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventDebugger>.NativeClassPtr);
			EventDebugger.NativeMethodInfoPtr_LogPropagationPaths_Public_Static_Void_EventBase_PropagationPaths_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDebugger>.NativeClassPtr, 100665982);
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x0005FAC0 File Offset: 0x0005DCC0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogPropagationPaths(EventBase evt, PropagationPaths paths)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paths);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDebugger.NativeMethodInfoPtr_LogPropagationPaths_Public_Static_Void_EventBase_PropagationPaths_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x000094AF File Offset: 0x000076AF
		public EventDebugger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x060012EB RID: 4843 RVA: 0x000094B8 File Offset: 0x000076B8
		// (set) Token: 0x060012EC RID: 4844 RVA: 0x000094C5 File Offset: 0x000076C5
		public IPanel panel
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x060012ED RID: 4845 RVA: 0x000094D2 File Offset: 0x000076D2
		// (set) Token: 0x060012EE RID: 4846 RVA: 0x000094DF File Offset: 0x000076DF
		public bool isReplaying
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x060012EF RID: 4847 RVA: 0x000094EC File Offset: 0x000076EC
		// (set) Token: 0x060012F0 RID: 4848 RVA: 0x000094F9 File Offset: 0x000076F9
		public float playbackSpeed
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x060012F1 RID: 4849 RVA: 0x00009506 File Offset: 0x00007706
		// (set) Token: 0x060012F2 RID: 4850 RVA: 0x00009513 File Offset: 0x00007713
		public bool isPlaybackPaused
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x00009520 File Offset: 0x00007720
		public void UpdateModificationCount()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x0000952D File Offset: 0x0000772D
		public void BeginProcessEvent(EventBase evt, IEventHandler mouseCapture)
		{
			this.AddBeginProcessEvent(evt, mouseCapture);
			this.UpdateModificationCount();
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x00009540 File Offset: 0x00007740
		public void EndProcessEvent(EventBase evt, long duration, IEventHandler mouseCapture)
		{
			this.AddEndProcessEvent(evt, duration, mouseCapture);
			this.UpdateModificationCount();
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x0005FB08 File Offset: 0x0005DD08
		public void LogCall(int cbHashCode, string cbName, EventBase evt, bool propagationHasStopped, bool immediatePropagationHasStopped, bool defaultHasBeenPrevented, long duration, IEventHandler mouseCapture)
		{
			this.AddCallObject(cbHashCode, cbName, evt, propagationHasStopped, immediatePropagationHasStopped, defaultHasBeenPrevented, duration, mouseCapture);
			this.UpdateModificationCount();
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x00009554 File Offset: 0x00007754
		public void LogIMGUICall(EventBase evt, long duration, IEventHandler mouseCapture)
		{
			this.AddIMGUICall(evt, duration, mouseCapture);
			this.UpdateModificationCount();
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x00009568 File Offset: 0x00007768
		public void LogExecuteDefaultAction(EventBase evt, PropagationPhase phase, long duration, IEventHandler mouseCapture)
		{
			this.AddExecuteDefaultAction(evt, phase, duration, mouseCapture);
			this.UpdateModificationCount();
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x0005FB34 File Offset: 0x0005DD34
		public void LogPropagationPathsInternal(EventBase evt, PropagationPaths paths)
		{
			PropagationPaths propagationPaths = ((paths == null) ? new PropagationPaths() : new PropagationPaths(paths));
			this.AddPropagationPaths(evt, propagationPaths);
			this.UpdateModificationCount();
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x0000957E File Offset: 0x0000777E
		public List<EventDebuggerCallTrace> GetCalls(IPanel panel, [Optional] EventDebuggerEventRecord evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x0000958B File Offset: 0x0000778B
		public List<EventDebuggerDefaultActionTrace> GetDefaultActions(IPanel panel, [Optional] EventDebuggerEventRecord evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x00009598 File Offset: 0x00007798
		public List<EventDebuggerPathTrace> GetPropagationPaths(IPanel panel, [Optional] EventDebuggerEventRecord evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x000095A5 File Offset: 0x000077A5
		public List<EventDebuggerTrace> GetBeginEndProcessedEvents(IPanel panel, [Optional] EventDebuggerEventRecord evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x000095B2 File Offset: 0x000077B2
		public long GetModificationCount(IPanel panel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x000095BF File Offset: 0x000077BF
		public void ClearLogs()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x000095CC File Offset: 0x000077CC
		public void SaveReplaySessionFromSelection(string path, List<EventDebuggerEventRecord> eventList)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x0005FB64 File Offset: 0x0005DD64
		public EventDebuggerRecordList LoadReplaySession(string path)
		{
			bool flag = String.IsNullOrEmpty(path);
			EventDebuggerRecordList eventDebuggerRecordList;
			if (flag)
			{
				eventDebuggerRecordList = null;
			}
			else
			{
				string text = File.ReadAllText(path);
				eventDebuggerRecordList = JsonUtility.FromJson<EventDebuggerRecordList>(text);
			}
			return eventDebuggerRecordList;
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x000095D9 File Offset: 0x000077D9
		public IEnumerator ReplayEvents(IEnumerable<EventDebuggerEventRecord> eventBases, Action<int, int> refreshList)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x000095E6 File Offset: 0x000077E6
		public void StopPlayback()
		{
			this.isReplaying = false;
			this.isPlaybackPaused = false;
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x000095F9 File Offset: 0x000077F9
		public IEnumerator DoReplayEvents(IEnumerable<EventDebuggerEventRecord> eventBases, Action<int, int> refreshList)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001305 RID: 4869 RVA: 0x00009606 File Offset: 0x00007806
		public Dictionary<long, int> eventTypeProcessedCount
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001306 RID: 4870 RVA: 0x00009613 File Offset: 0x00007813
		// (set) Token: 0x06001307 RID: 4871 RVA: 0x00009620 File Offset: 0x00007820
		public bool suspended
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x0000962D File Offset: 0x0000782D
		public void AddCallObject(int cbHashCode, string cbName, EventBase evt, bool propagationHasStopped, bool immediatePropagationHasStopped, bool defaultHasBeenPrevented, long duration, IEventHandler mouseCapture)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x0000963A File Offset: 0x0000783A
		public void AddExecuteDefaultAction(EventBase evt, PropagationPhase phase, long duration, IEventHandler mouseCapture)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x00009647 File Offset: 0x00007847
		public void AddPropagationPaths(EventBase evt, PropagationPaths paths)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x00009654 File Offset: 0x00007854
		public void AddIMGUICall(EventBase evt, long duration, IEventHandler mouseCapture)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x00009661 File Offset: 0x00007861
		public void AddBeginProcessEvent(EventBase evt, IEventHandler mouseCapture)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x0000966E File Offset: 0x0000786E
		public void AddEndProcessEvent(EventBase evt, long duration, IEventHandler mouseCapture)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x0005FB94 File Offset: 0x0005DD94
		public static string GetObjectDisplayName(Object obj, [Optional] bool withHashCode)
		{
			bool flag = obj == null;
			string text;
			if (flag)
			{
				text = String.Empty;
			}
			else
			{
				Type type = obj.GetType();
				string text2 = EventDebugger.GetTypeDisplayName(type);
				bool flag2 = obj.TryCast<VisualElement>() != null;
				if (flag2)
				{
					VisualElement visualElement = obj.TryCast<VisualElement>();
					bool flag3 = !String.IsNullOrEmpty(visualElement.name);
					if (flag3)
					{
						text2 = String.Concat(text2, "#", visualElement.name);
					}
				}
				if (withHashCode)
				{
					text2 = String.Concat(text2, " (", obj.GetHashCode().ToString("x8"), ")");
				}
				text = text2;
			}
			return text;
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x0000967B File Offset: 0x0000787B
		public static string GetTypeDisplayName(Type type)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000CF8 RID: 3320
		private static readonly IntPtr NativeMethodInfoPtr_LogPropagationPaths_Public_Static_Void_EventBase_PropagationPaths_0;

		// Token: 0x020003FE RID: 1022
		[Serializable]
		public sealed class <>c
		{
		}

		// Token: 0x020003FF RID: 1023
		public sealed class <>c__DisplayClass34_0
		{
			// Token: 0x0200058F RID: 1423
			public sealed class <<DoReplayEvents>g__AwaitForNextEvent|1>d
			{
			}
		}

		// Token: 0x02000400 RID: 1024
		public sealed class <DoReplayEvents>d__34
		{
		}

		// Token: 0x02000401 RID: 1025
		public sealed class <ReplayEvents>d__32
		{
		}
	}
}
